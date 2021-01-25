namespace SerialPortApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDataReceive = new System.Windows.Forms.TextBox();
            this.groupBox_receive = new System.Windows.Forms.GroupBox();
            this.rxEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox_transmit = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbDataTransmit = new System.Windows.Forms.TextBox();
            this.groupBox_exceptions = new System.Windows.Forms.GroupBox();
            this.error_label = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSerialPort = new System.Windows.Forms.TabPage();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.groupBoxStSelectTemperature = new System.Windows.Forms.GroupBox();
            this.btnStSetTemp = new System.Windows.Forms.Button();
            this.textBoxStSetTemp = new System.Windows.Forms.TextBox();
            this.labelStUnitTemperature = new System.Windows.Forms.Label();
            this.labelStTemperatureValue = new System.Windows.Forms.Label();
            this.trackBarStSelectTemperature = new System.Windows.Forms.TrackBar();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.groupBoxOcGraphControl = new System.Windows.Forms.GroupBox();
            this.btnOcReset = new System.Windows.Forms.Button();
            this.btnOcStart = new System.Windows.Forms.Button();
            this.groupBoxOcStatementOfTemperature = new System.Windows.Forms.GroupBox();
            this.textBoxOcRealTimeTemp = new System.Windows.Forms.TextBox();
            this.chartOcGraphTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelOcUnitRealTimeTemperature = new System.Windows.Forms.Label();
            this.labelOcRealTimeTemperatue = new System.Windows.Forms.Label();
            this.labelOcTargetTemperatue = new System.Windows.Forms.Label();
            this.textBoxOcSetTemp = new System.Windows.Forms.TextBox();
            this.labelOcUnitTargetTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_receive.SuspendLayout();
            this.groupBox_transmit.SuspendLayout();
            this.groupBox_exceptions.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSerialPort.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.groupBoxStSelectTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStSelectTemperature)).BeginInit();
            this.tabControl.SuspendLayout();
            this.groupBoxOcGraphControl.SuspendLayout();
            this.groupBoxOcStatementOfTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcGraphTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(10, 59);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(10, 86);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLabel.TabIndex = 3;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(10, 113);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(36, 13);
            this.parityLabel.TabIndex = 5;
            this.parityLabel.Text = "Parity:";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(10, 32);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(60, 13);
            this.portNameLabel.TabIndex = 7;
            this.portNameLabel.Text = "Port Name:";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(10, 140);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLabel.TabIndex = 9;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(77, 56);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(153, 21);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(77, 83);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.dataBitsComboBox.TabIndex = 4;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(77, 110);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(153, 21);
            this.parityComboBox.TabIndex = 6;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(77, 29);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(153, 21);
            this.portNameComboBox.TabIndex = 8;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(77, 137);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_settings.Controls.Add(this.baudRateComboBox);
            this.groupBox_settings.Controls.Add(this.btnStop);
            this.groupBox_settings.Controls.Add(this.baudRateLabel);
            this.groupBox_settings.Controls.Add(this.btnStart);
            this.groupBox_settings.Controls.Add(this.stopBitsComboBox);
            this.groupBox_settings.Controls.Add(this.stopBitsLabel);
            this.groupBox_settings.Controls.Add(this.dataBitsLabel);
            this.groupBox_settings.Controls.Add(this.portNameComboBox);
            this.groupBox_settings.Controls.Add(this.dataBitsComboBox);
            this.groupBox_settings.Controls.Add(this.portNameLabel);
            this.groupBox_settings.Controls.Add(this.parityLabel);
            this.groupBox_settings.Controls.Add(this.parityComboBox);
            this.groupBox_settings.Location = new System.Drawing.Point(8, 6);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(244, 200);
            this.groupBox_settings.TabIndex = 11;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Serial Port Settings";
            this.groupBox_settings.Enter += new System.EventHandler(this.groupBox_settings_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(157, 164);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Disconnect";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(77, 164);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDataReceive
            // 
            this.tbDataReceive.Location = new System.Drawing.Point(11, 19);
            this.tbDataReceive.Multiline = true;
            this.tbDataReceive.Name = "tbDataReceive";
            this.tbDataReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReceive.Size = new System.Drawing.Size(494, 97);
            this.tbDataReceive.TabIndex = 13;
            // 
            // groupBox_receive
            // 
            this.groupBox_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_receive.Controls.Add(this.rxEnableCheckBox);
            this.groupBox_receive.Controls.Add(this.btnClear);
            this.groupBox_receive.Controls.Add(this.tbDataReceive);
            this.groupBox_receive.Location = new System.Drawing.Point(9, 212);
            this.groupBox_receive.Name = "groupBox_receive";
            this.groupBox_receive.Size = new System.Drawing.Size(511, 150);
            this.groupBox_receive.TabIndex = 14;
            this.groupBox_receive.TabStop = false;
            this.groupBox_receive.Text = "Receive";
            // 
            // rxEnableCheckBox
            // 
            this.rxEnableCheckBox.AutoSize = true;
            this.rxEnableCheckBox.Checked = true;
            this.rxEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rxEnableCheckBox.Location = new System.Drawing.Point(11, 121);
            this.rxEnableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.rxEnableCheckBox.Name = "rxEnableCheckBox";
            this.rxEnableCheckBox.Size = new System.Drawing.Size(75, 17);
            this.rxEnableCheckBox.TabIndex = 15;
            this.rxEnableCheckBox.Text = "Rx Enable";
            this.rxEnableCheckBox.UseVisualStyleBackColor = true;
            this.rxEnableCheckBox.CheckedChanged += new System.EventHandler(this.rxEnableCheckBox_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox_transmit
            // 
            this.groupBox_transmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transmit.Controls.Add(this.btnSend);
            this.groupBox_transmit.Controls.Add(this.tbDataTransmit);
            this.groupBox_transmit.Location = new System.Drawing.Point(8, 369);
            this.groupBox_transmit.Name = "groupBox_transmit";
            this.groupBox_transmit.Size = new System.Drawing.Size(511, 72);
            this.groupBox_transmit.TabIndex = 15;
            this.groupBox_transmit.TabStop = false;
            this.groupBox_transmit.Text = "Transmit";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(420, 43);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbDataTransmit
            // 
            this.tbDataTransmit.Location = new System.Drawing.Point(12, 19);
            this.tbDataTransmit.Name = "tbDataTransmit";
            this.tbDataTransmit.Size = new System.Drawing.Size(494, 20);
            this.tbDataTransmit.TabIndex = 0;
            // 
            // groupBox_exceptions
            // 
            this.groupBox_exceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_exceptions.Controls.Add(this.error_label);
            this.groupBox_exceptions.Location = new System.Drawing.Point(258, 6);
            this.groupBox_exceptions.Name = "groupBox_exceptions";
            this.groupBox_exceptions.Size = new System.Drawing.Size(261, 200);
            this.groupBox_exceptions.TabIndex = 16;
            this.groupBox_exceptions.TabStop = false;
            this.groupBox_exceptions.Text = "Exceptions";
            // 
            // error_label
            // 
            this.error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(3, 16);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(255, 181);
            this.error_label.TabIndex = 0;
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSerialPort);
            this.tabMain.Controls.Add(this.tabInput);
            this.tabMain.Controls.Add(this.tabControl);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(532, 472);
            this.tabMain.TabIndex = 17;
            // 
            // tabSerialPort
            // 
            this.tabSerialPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabSerialPort.Controls.Add(this.groupBox_settings);
            this.tabSerialPort.Controls.Add(this.groupBox_exceptions);
            this.tabSerialPort.Controls.Add(this.groupBox_transmit);
            this.tabSerialPort.Controls.Add(this.groupBox_receive);
            this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tabSerialPort.Name = "tabSerialPort";
            this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialPort.Size = new System.Drawing.Size(524, 446);
            this.tabSerialPort.TabIndex = 0;
            this.tabSerialPort.Text = "Serial Port";
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.groupBoxStSelectTemperature);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Margin = new System.Windows.Forms.Padding(2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(2);
            this.tabInput.Size = new System.Drawing.Size(524, 446);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Set Temperature";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // groupBoxStSelectTemperature
            // 
            this.groupBoxStSelectTemperature.Controls.Add(this.btnStSetTemp);
            this.groupBoxStSelectTemperature.Controls.Add(this.textBoxStSetTemp);
            this.groupBoxStSelectTemperature.Controls.Add(this.labelStUnitTemperature);
            this.groupBoxStSelectTemperature.Controls.Add(this.labelStTemperatureValue);
            this.groupBoxStSelectTemperature.Controls.Add(this.trackBarStSelectTemperature);
            this.groupBoxStSelectTemperature.Location = new System.Drawing.Point(5, 5);
            this.groupBoxStSelectTemperature.Name = "groupBoxStSelectTemperature";
            this.groupBoxStSelectTemperature.Size = new System.Drawing.Size(514, 97);
            this.groupBoxStSelectTemperature.TabIndex = 1;
            this.groupBoxStSelectTemperature.TabStop = false;
            this.groupBoxStSelectTemperature.Text = "Select Temperature";
            this.groupBoxStSelectTemperature.Enter += new System.EventHandler(this.groupBoxStSelectTemperature_Enter);
            // 
            // btnStSetTemp
            // 
            this.btnStSetTemp.Enabled = false;
            this.btnStSetTemp.Location = new System.Drawing.Point(396, 68);
            this.btnStSetTemp.Name = "btnStSetTemp";
            this.btnStSetTemp.Size = new System.Drawing.Size(112, 23);
            this.btnStSetTemp.TabIndex = 3;
            this.btnStSetTemp.Text = "Set Temperature";
            this.btnStSetTemp.UseVisualStyleBackColor = true;
            this.btnStSetTemp.Click += new System.EventHandler(this.btnStSetTemp_Click);
            // 
            // textBoxStSetTemp
            // 
            this.textBoxStSetTemp.Location = new System.Drawing.Point(117, 71);
            this.textBoxStSetTemp.Name = "textBoxStSetTemp";
            this.textBoxStSetTemp.ReadOnly = true;
            this.textBoxStSetTemp.Size = new System.Drawing.Size(37, 20);
            this.textBoxStSetTemp.TabIndex = 2;
            this.textBoxStSetTemp.Text = "20.00";
            this.textBoxStSetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStSetTemp.TextChanged += new System.EventHandler(this.textBoxStSetTemp_TextChanged);
            // 
            // labelStUnitTemperature
            // 
            this.labelStUnitTemperature.AutoSize = true;
            this.labelStUnitTemperature.Location = new System.Drawing.Point(153, 74);
            this.labelStUnitTemperature.Name = "labelStUnitTemperature";
            this.labelStUnitTemperature.Size = new System.Drawing.Size(24, 13);
            this.labelStUnitTemperature.TabIndex = 2;
            this.labelStUnitTemperature.Text = "[°C]";
            this.labelStUnitTemperature.Click += new System.EventHandler(this.labelStUnitTemperature_Click);
            // 
            // labelStTemperatureValue
            // 
            this.labelStTemperatureValue.AutoSize = true;
            this.labelStTemperatureValue.Location = new System.Drawing.Point(7, 74);
            this.labelStTemperatureValue.Name = "labelStTemperatureValue";
            this.labelStTemperatureValue.Size = new System.Drawing.Size(112, 13);
            this.labelStTemperatureValue.TabIndex = 1;
            this.labelStTemperatureValue.Text = "Selected Temperatue:";
            this.labelStTemperatureValue.Click += new System.EventHandler(this.labelStTemperatureValue_Click);
            // 
            // trackBarStSelectTemperature
            // 
            this.trackBarStSelectTemperature.Location = new System.Drawing.Point(6, 19);
            this.trackBarStSelectTemperature.Maximum = 3500;
            this.trackBarStSelectTemperature.Minimum = 2000;
            this.trackBarStSelectTemperature.Name = "trackBarStSelectTemperature";
            this.trackBarStSelectTemperature.Size = new System.Drawing.Size(502, 45);
            this.trackBarStSelectTemperature.SmallChange = 25;
            this.trackBarStSelectTemperature.TabIndex = 0;
            this.trackBarStSelectTemperature.TickFrequency = 25;
            this.trackBarStSelectTemperature.Value = 2000;
            this.trackBarStSelectTemperature.Scroll += new System.EventHandler(this.trackBarStSelectTemperature_Scroll);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.groupBoxOcGraphControl);
            this.tabControl.Controls.Add(this.groupBoxOcStatementOfTemperature);
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(2);
            this.tabControl.Size = new System.Drawing.Size(524, 446);
            this.tabControl.TabIndex = 2;
            this.tabControl.Text = "Output control";
            this.tabControl.UseVisualStyleBackColor = true;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // groupBoxOcGraphControl
            // 
            this.groupBoxOcGraphControl.Controls.Add(this.btnOcReset);
            this.groupBoxOcGraphControl.Controls.Add(this.btnOcStart);
            this.groupBoxOcGraphControl.Location = new System.Drawing.Point(5, 408);
            this.groupBoxOcGraphControl.Name = "groupBoxOcGraphControl";
            this.groupBoxOcGraphControl.Size = new System.Drawing.Size(514, 35);
            this.groupBoxOcGraphControl.TabIndex = 2;
            this.groupBoxOcGraphControl.TabStop = false;
            this.groupBoxOcGraphControl.Text = "Graph Control";
            this.groupBoxOcGraphControl.Enter += new System.EventHandler(this.groupBoxOcGraphControl_Enter);
            // 
            // btnOcReset
            // 
            this.btnOcReset.Enabled = false;
            this.btnOcReset.Location = new System.Drawing.Point(396, 10);
            this.btnOcReset.Name = "btnOcReset";
            this.btnOcReset.Size = new System.Drawing.Size(112, 23);
            this.btnOcReset.TabIndex = 5;
            this.btnOcReset.Text = "Reset";
            this.btnOcReset.UseVisualStyleBackColor = true;
            this.btnOcReset.Click += new System.EventHandler(this.btnOcReset_Click);
            // 
            // btnOcStart
            // 
            this.btnOcStart.Enabled = false;
            this.btnOcStart.Location = new System.Drawing.Point(278, 10);
            this.btnOcStart.Name = "btnOcStart";
            this.btnOcStart.Size = new System.Drawing.Size(112, 23);
            this.btnOcStart.TabIndex = 4;
            this.btnOcStart.Text = "Start";
            this.btnOcStart.UseVisualStyleBackColor = true;
            this.btnOcStart.Click += new System.EventHandler(this.btnOcStart_Click);
            // 
            // groupBoxOcStatementOfTemperature
            // 
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.textBoxOcRealTimeTemp);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.chartOcGraphTemperature);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.labelOcUnitRealTimeTemperature);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.labelOcRealTimeTemperatue);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.labelOcTargetTemperatue);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.textBoxOcSetTemp);
            this.groupBoxOcStatementOfTemperature.Controls.Add(this.labelOcUnitTargetTemperature);
            this.groupBoxOcStatementOfTemperature.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOcStatementOfTemperature.Name = "groupBoxOcStatementOfTemperature";
            this.groupBoxOcStatementOfTemperature.Size = new System.Drawing.Size(514, 403);
            this.groupBoxOcStatementOfTemperature.TabIndex = 1;
            this.groupBoxOcStatementOfTemperature.TabStop = false;
            this.groupBoxOcStatementOfTemperature.Text = "Statement of Temperature";
            this.groupBoxOcStatementOfTemperature.Enter += new System.EventHandler(this.groupBoxOcStatementOfTemperature_Enter);
            // 
            // textBoxOcRealTimeTemp
            // 
            this.textBoxOcRealTimeTemp.Location = new System.Drawing.Point(280, 377);
            this.textBoxOcRealTimeTemp.Name = "textBoxOcRealTimeTemp";
            this.textBoxOcRealTimeTemp.ReadOnly = true;
            this.textBoxOcRealTimeTemp.Size = new System.Drawing.Size(37, 20);
            this.textBoxOcRealTimeTemp.TabIndex = 8;
            this.textBoxOcRealTimeTemp.Text = "20.00";
            this.textBoxOcRealTimeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOcRealTimeTemp.TextChanged += new System.EventHandler(this.textBoxOcRealTimeTemp_TextChanged);
            // 
            // chartOcGraphTemperature
            // 
            chartArea5.AxisX.Maximum = 60D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisX.Title = "Time [s]";
            chartArea5.AxisY.Interval = 5D;
            chartArea5.AxisY.LogarithmBase = 1000D;
            chartArea5.AxisY.Maximum = 40D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.AxisY.Title = "Temperature [°]";
            chartArea5.BorderColor = System.Drawing.Color.DimGray;
            chartArea5.Name = "ChartArea1";
            this.chartOcGraphTemperature.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.chartOcGraphTemperature.Legends.Add(legend5);
            this.chartOcGraphTemperature.Location = new System.Drawing.Point(6, 19);
            this.chartOcGraphTemperature.Name = "chartOcGraphTemperature";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Real-Time Temperature";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Target Temperature";
            this.chartOcGraphTemperature.Series.Add(series9);
            this.chartOcGraphTemperature.Series.Add(series10);
            this.chartOcGraphTemperature.Size = new System.Drawing.Size(502, 358);
            this.chartOcGraphTemperature.TabIndex = 0;
            this.chartOcGraphTemperature.Text = "chart1";
            this.chartOcGraphTemperature.Click += new System.EventHandler(this.chartOcGraphTemperature_Click);
            // 
            // labelOcUnitRealTimeTemperature
            // 
            this.labelOcUnitRealTimeTemperature.AutoSize = true;
            this.labelOcUnitRealTimeTemperature.Location = new System.Drawing.Point(316, 380);
            this.labelOcUnitRealTimeTemperature.Name = "labelOcUnitRealTimeTemperature";
            this.labelOcUnitRealTimeTemperature.Size = new System.Drawing.Size(24, 13);
            this.labelOcUnitRealTimeTemperature.TabIndex = 7;
            this.labelOcUnitRealTimeTemperature.Text = "[°C]";
            // 
            // labelOcRealTimeTemperatue
            // 
            this.labelOcRealTimeTemperatue.AutoSize = true;
            this.labelOcRealTimeTemperatue.Location = new System.Drawing.Point(162, 380);
            this.labelOcRealTimeTemperatue.Name = "labelOcRealTimeTemperatue";
            this.labelOcRealTimeTemperatue.Size = new System.Drawing.Size(118, 13);
            this.labelOcRealTimeTemperatue.TabIndex = 6;
            this.labelOcRealTimeTemperatue.Text = "Real-Time Temperatue:";
            this.labelOcRealTimeTemperatue.Click += new System.EventHandler(this.labelOcRealTimeTemperatue_Click);
            // 
            // labelOcTargetTemperatue
            // 
            this.labelOcTargetTemperatue.AutoSize = true;
            this.labelOcTargetTemperatue.Location = new System.Drawing.Point(0, 380);
            this.labelOcTargetTemperatue.Name = "labelOcTargetTemperatue";
            this.labelOcTargetTemperatue.Size = new System.Drawing.Size(101, 13);
            this.labelOcTargetTemperatue.TabIndex = 3;
            this.labelOcTargetTemperatue.Text = "Target Temperatue:";
            this.labelOcTargetTemperatue.Click += new System.EventHandler(this.labelOcTargetTemperatue_Click);
            // 
            // textBoxOcSetTemp
            // 
            this.textBoxOcSetTemp.Location = new System.Drawing.Point(101, 377);
            this.textBoxOcSetTemp.Name = "textBoxOcSetTemp";
            this.textBoxOcSetTemp.ReadOnly = true;
            this.textBoxOcSetTemp.Size = new System.Drawing.Size(37, 20);
            this.textBoxOcSetTemp.TabIndex = 5;
            this.textBoxOcSetTemp.Text = "xx.xx";
            this.textBoxOcSetTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOcSetTemp.TextChanged += new System.EventHandler(this.textBoxOcSetTemp_TextChanged);
            // 
            // labelOcUnitTargetTemperature
            // 
            this.labelOcUnitTargetTemperature.AutoSize = true;
            this.labelOcUnitTargetTemperature.Location = new System.Drawing.Point(137, 380);
            this.labelOcUnitTargetTemperature.Name = "labelOcUnitTargetTemperature";
            this.labelOcUnitTargetTemperature.Size = new System.Drawing.Size(24, 13);
            this.labelOcUnitTargetTemperature.TabIndex = 4;
            this.labelOcUnitTargetTemperature.Text = "[°C]";
            this.labelOcUnitTargetTemperature.Click += new System.EventHandler(this.labelOcUnitTargetTemperature_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "C# Serial Port App";
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_receive.ResumeLayout(false);
            this.groupBox_receive.PerformLayout();
            this.groupBox_transmit.ResumeLayout(false);
            this.groupBox_transmit.PerformLayout();
            this.groupBox_exceptions.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSerialPort.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.groupBoxStSelectTemperature.ResumeLayout(false);
            this.groupBoxStSelectTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStSelectTemperature)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.groupBoxOcGraphControl.ResumeLayout(false);
            this.groupBoxOcStatementOfTemperature.ResumeLayout(false);
            this.groupBoxOcStatementOfTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOcGraphTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbDataReceive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.GroupBox groupBox_receive;
        private System.Windows.Forms.GroupBox groupBox_transmit;
        private System.Windows.Forms.TextBox tbDataTransmit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox_exceptions;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSerialPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.CheckBox rxEnableCheckBox;
        private System.Windows.Forms.GroupBox groupBoxStSelectTemperature;
        private System.Windows.Forms.Button btnStSetTemp;
        private System.Windows.Forms.TextBox textBoxStSetTemp;
        private System.Windows.Forms.Label labelStUnitTemperature;
        private System.Windows.Forms.Label labelStTemperatureValue;
        private System.Windows.Forms.TrackBar trackBarStSelectTemperature;
        private System.Windows.Forms.GroupBox groupBoxOcStatementOfTemperature;
        private System.Windows.Forms.TextBox textBoxOcSetTemp;
        private System.Windows.Forms.Label labelOcUnitTargetTemperature;
        private System.Windows.Forms.Label labelOcTargetTemperatue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOcGraphTemperature;
        private System.Windows.Forms.TextBox textBoxOcRealTimeTemp;
        private System.Windows.Forms.Label labelOcUnitRealTimeTemperature;
        private System.Windows.Forms.Label labelOcRealTimeTemperatue;
        private System.Windows.Forms.GroupBox groupBoxOcGraphControl;
        private System.Windows.Forms.Button btnOcStart;
        private System.Windows.Forms.Button btnOcReset;
    }
}

