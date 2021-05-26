/**
*   @author Kacper Dominiak
*   @file MainForm.cs
*   @date 02.02.2021
*   @brief Main form class.
*   Based on project by Amund Gjersøe (www.codeproject.com/Articles/75770/Basic-serial-port-listening-application)
*/

/*
 * System libraries
 */
using System;
using System.Text;
using System.Windows.Forms;
using SerialPortApp.Serial;
using System.Globalization;
using System.Diagnostics;

namespace SerialPortApp
{
    /*
    * Main form class. Inherit from form Form class.
    * Partial definition -  remider of the class defined in 
    * automatically generated file MainForm.designer.cs
    */
    public partial class MainForm : Form
    {
        //! Default constructor.
        public MainForm()
        {
            InitializeComponent();
            UserInitialization();
        }

        #region Fields

        SerialPortManager _spManager; /** Custom serial port manager class object. */
            
        private int _smallChangeValue = 25;
        private int _tempValue = 2000;
        private int _tempSetValue = 2000;
        private bool _blockRecursion = false;
        private string _realTimeTemp;
        private const int _spMsgSize = 4;
        private double _plotTimeStep = 1;
        private double _plotTimeMax = 60.0;
        private double _plotTime = 0.0;
        private bool _isTempSet = false;
        private bool _ifConnected = false;

        #endregion

        #region Event handlers

        /*
         * Main form window closing event handling function.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the form closing event data.
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }

        /*
        * New serial port data recived event handlig function. Update of "tbDataReceive" text box.
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the serial port event data.
        */
        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            int maxTextLength = 1000; // maximum text length in text box
            if (tbDataReceive.TextLength > maxTextLength)
                tbDataReceive.Text = tbDataReceive.Text.Remove(0, tbDataReceive.TextLength - maxTextLength);

            // Byte array to string
            string str = Encoding.ASCII.GetString(e.Data);

            tbDataReceive.AppendText(str);
            tbDataReceive.ScrollToCaret();
        }

        /*
        * Error handling function. Display message in groupBox "Exceptions".
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void _spManager_ErrorHandler(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<EventArgs>(_spManager_ErrorHandler), new object[] { sender, e });
                return;
            }
            error_label.Text = ((Exception)sender).Message;
        }

        /*
        * Handles the "Connect"-buttom click event
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void btnStart_Click(object sender, EventArgs e)
        {
            Connect();
            btnStSetTemp.Enabled = true;
            btnOcStart.Enabled = true;
            btnOcReset.Enabled = true;


        }

        /*
        * Handles the "Diconnect"-buttom click event
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void btnStop_Click(object sender, EventArgs e)
        {
            Disonnect();
            btnStSetTemp.Enabled = false;
            btnOcStart.Enabled = false;
            btnOcReset.Enabled = false;

        }

        /*
        * Handles the "Send"-buttom click event
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void btnSend_Click(object sender, EventArgs e)
        {
            _spManager.Send(tbDataTransmit.Text);
        }

        /*
        * Handles the "Clear"-buttom click event
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDataReceive.Clear();
        }

        /*
         * Receive text box 'Rx Enable' check box click event method.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void rxEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rxEnableCheckBox.Checked)
                RxTextBoxEnable();
            else
                RxTextBoxDisable();
        }

        #endregion

        #region Methods

        /*
         * User custom initialization.
         */
        private void UserInitialization()
        {
            // New serial port manager
            _spManager = new SerialPortManager();

            // Read current serial port settings 
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;

            // Bind serial port & user interface data sources with serial port settings
            serialSettingsBindingSource.DataSource = mySerialSettings;
            portNameComboBox.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            // Add evnet handling functions to serial port manager
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            _spManager.ErrorHandler += new EventHandler<EventArgs>(_spManager_ErrorHandler);

            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

            // Diable "Disconnect" button
            btnStop.Enabled = false;

            chartOcGraphTemperature.Series[0].Points.AddXY(double .NaN, double .NaN);

       
        }

        /*
        * Connect procedure - open and start listening on COM port.
        */
        private void Connect()
        {
            if (_spManager.StartListening())
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                portNameComboBox.Enabled = false;
                baudRateComboBox.Enabled = false;
                dataBitsComboBox.Enabled = false;
                parityComboBox.Enabled = false;
                stopBitsComboBox.Enabled = false;
            }
        }

        /*
        * Disconnect procedure - close and stop listening on COM port.
        */
        private void Disonnect()
        {
            _spManager.StopListening();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            portNameComboBox.Enabled = true;
            baudRateComboBox.Enabled = true;
            dataBitsComboBox.Enabled = true;
            parityComboBox.Enabled = true;
            stopBitsComboBox.Enabled = true;
        }
   
        /*
         * Enables receive text box.
         */
        private void RxTextBoxEnable()
        {
            rxEnableCheckBox.Checked = true;
            tbDataReceive.Enabled = true;
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
        }

        /*
         * Disables receive text box.
         */
        private void RxTextBoxDisable()
        {
            rxEnableCheckBox.Checked = false;
            tbDataReceive.Enabled = false;
            _spManager.NewSerialDataRecieved -= new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
        }

        #endregion
        


        private void groupBox_settings_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl_Click(object sender, EventArgs e)
        {

        }

        /*
         * Selecting value of Temperature in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void trackBarStSelectTemperature_Scroll(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;

            /* Implementation of trackBar step  */
            if (_blockRecursion) return;

            _tempValue = trackBar.Value;

            if (_tempValue % _smallChangeValue != 0)
            {
                _tempValue = (_tempValue / _smallChangeValue) * _smallChangeValue;
                _blockRecursion = true;
                trackBar.Value = _tempValue;
                _blockRecursion = false;
            }

            /* Set value in textBox*/
            textBoxStSetTemp.Text = (_tempValue * 0.01).ToString("00.00");
        }

        /*
         * Input plot new data recived event handling function. Update of 'plotInput' chart.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        void _spManager_NewPlotDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewPlotDataRecieved), new object[] { sender, e });
                return;
            }

            string msg = Encoding.ASCII.GetString(e.Data);
            _realTimeTemp += msg;

            if (_realTimeTemp.Length >= _spMsgSize)
            {

                if(_plotTime > _plotTimeMax)
                {
                    chartOcGraphTemperature.ChartAreas[0].AxisX.Maximum = _plotTime; //
                }

                _realTimeTemp = _realTimeTemp.Substring(0, 2) + "." + _realTimeTemp.Substring(2, 2);
                chartOcGraphTemperature.Series[0].Points.AddXY(_plotTime, _realTimeTemp);
                if (_isTempSet)
                {
                    
                    string _tempStrSetValue = _tempSetValue.ToString();
                    _tempStrSetValue = _tempStrSetValue.Substring(0, 2) + "." + _tempStrSetValue.Substring(2, 2);
                    chartOcGraphTemperature.Series[1].Points.AddXY(_plotTime, _tempStrSetValue);
                }
                
                textBoxOcRealTimeTemp.Text = _realTimeTemp;
                _plotTime += _plotTimeStep;
                _realTimeTemp = "";


            }
        }

        /*
         * Plotting value of Real-Time  and Target Temperatue.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void chartOcGraphTemperature_Click(object sender, EventArgs e)
        {

        }

        /*
         * Input plot 'Reset' button click event method in Output Control card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void btnOcReset_Click(object sender, EventArgs e)
        {
            RxTextBoxEnable();
            _spManager.NewSerialDataRecieved -= new EventHandler<SerialDataEventArgs>(_spManager_NewPlotDataRecieved);

            chartOcGraphTemperature.Series[0].Points.Clear();
            chartOcGraphTemperature.Series[0].Points.AddXY(double.NaN, double.NaN);

            chartOcGraphTemperature.Series[1].Points.Clear();
            chartOcGraphTemperature.Series[1].Points.AddXY(double.NaN, double.NaN);

            chartOcGraphTemperature.ChartAreas[0].AxisX.Minimum = 0;
            chartOcGraphTemperature.ChartAreas[0].AxisX.Maximum = _plotTimeMax;
            _plotTime = 0;
        }

        /*
         * Input plot 'Start' button click event method in Output Control card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void btnOcStart_Click(object sender, EventArgs e)
        {
            RxTextBoxDisable();
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewPlotDataRecieved);
        }

        /*
         * Showing value of setting temperature in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void textBoxStSetTemp_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Transmitting value of setting temperature to chartOcGraphTemperature and STM32 by USART in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void btnStSetTemp_Click(object sender, EventArgs e)
        {
            _tempSetValue = _tempValue;
            _spManager.Send(_tempSetValue.ToString());
            textBoxOcSetTemp.Text = (_tempSetValue * 0.01).ToString("00.00");
            _isTempSet = true;
        }

        /*
         * Showing value of setting temperature in Outpuc Control card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void textBoxOcSetTemp_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Showing value of real-time temperature in Outpuc Control card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void textBoxOcRealTimeTemp_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * Showing label of Temperature in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void labelStTemperatureValue_Click(object sender, EventArgs e)
        {

        }

        /*
         * Showing label of unit Temperature in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void labelStUnitTemperature_Click(object sender, EventArgs e)
        {

        }

        /*
         * Showing label of Target Temperature in Output Contol card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void labelOcTargetTemperatue_Click(object sender, EventArgs e)
        {

        }

        /*
         * Showing label of unit Temperature in in Output Contol card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void labelOcUnitTargetTemperature_Click(object sender, EventArgs e)
        {

        }

        /*
        * Showing label of Real-Time Temperature in in Output Contol card.
        * @param sender - contains a reference to the control/object that raised the event.
        * @param e - contains the event data.
        */
        private void labelOcRealTimeTemperatue_Click(object sender, EventArgs e)
        {

        }


        /*
         * Group box of Graph Control in Output Contol card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void groupBoxOcGraphControl_Enter(object sender, EventArgs e)
        {

        }

        /*
         * Group box of Steatement of Temperrature in Output Contol card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void groupBoxOcStatementOfTemperature_Enter(object sender, EventArgs e)
        {

        }

        /*
         * Group box of Selecet Temperrature in Set Temperature card.
         * @param sender - contains a reference to the control/object that raised the event.
         * @param e - contains the event data.
         */
        private void groupBoxStSelectTemperature_Enter(object sender, EventArgs e)
        {

        }

     
    }
}

