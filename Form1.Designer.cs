namespace VCPSTMTerminal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenPort = new System.Windows.Forms.Button();
            this.TxRx = new System.Windows.Forms.RichTextBox();
            this.ClosePort = new System.Windows.Forms.Button();
            this.GetPorts = new System.Windows.Forms.Button();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.PortConnectedStatus = new System.Windows.Forms.Label();
            this.CommandPalete = new System.Windows.Forms.TextBox();
            this.ClearTxRx = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DEBUG = new System.Windows.Forms.TabPage();
            this.SPI = new System.Windows.Forms.TabPage();
            this.DBG = new System.Windows.Forms.RichTextBox();
            this.SPI_Send = new System.Windows.Forms.RichTextBox();
            this.SPI_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LMX2594 = new System.Windows.Forms.TabPage();
            this.RegisterName = new System.Windows.Forms.Label();
            this.RegisterPrefix = new System.Windows.Forms.Label();
            this.SPI_Write = new System.Windows.Forms.CheckBox();
            this.SPI_Read = new System.Windows.Forms.CheckBox();
            this.RegNo = new System.Windows.Forms.NumericUpDown();
            this.RegVal = new System.Windows.Forms.TextBox();
            this.RegisterVal = new System.Windows.Forms.Label();
            this.Operate = new System.Windows.Forms.Button();
            this.ClearHex = new System.Windows.Forms.TextBox();
            this.ClearHexLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DEBUG.SuspendLayout();
            this.SPI.SuspendLayout();
            this.LMX2594.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegNo)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(3, 7);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(75, 23);
            this.OpenPort.TabIndex = 0;
            this.OpenPort.Text = "OpenPort";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // TxRx
            // 
            this.TxRx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxRx.Location = new System.Drawing.Point(3, 65);
            this.TxRx.Name = "TxRx";
            this.TxRx.Size = new System.Drawing.Size(355, 249);
            this.TxRx.TabIndex = 1;
            this.TxRx.Text = "";
            // 
            // ClosePort
            // 
            this.ClosePort.Location = new System.Drawing.Point(3, 36);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(75, 23);
            this.ClosePort.TabIndex = 2;
            this.ClosePort.Text = "ClosePort";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // GetPorts
            // 
            this.GetPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetPorts.Location = new System.Drawing.Point(283, 7);
            this.GetPorts.Name = "GetPorts";
            this.GetPorts.Size = new System.Drawing.Size(75, 23);
            this.GetPorts.TabIndex = 4;
            this.GetPorts.Text = "GetPorts";
            this.GetPorts.UseVisualStyleBackColor = true;
            this.GetPorts.Click += new System.EventHandler(this.GetPorts_Click);
            // 
            // PortList
            // 
            this.PortList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(84, 7);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(193, 21);
            this.PortList.TabIndex = 7;
            this.PortList.SelectedIndexChanged += new System.EventHandler(this.PortList_SelectedIndexChanged);
            // 
            // PortConnectedStatus
            // 
            this.PortConnectedStatus.AutoSize = true;
            this.PortConnectedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PortConnectedStatus.Location = new System.Drawing.Point(85, 36);
            this.PortConnectedStatus.Name = "PortConnectedStatus";
            this.PortConnectedStatus.Size = new System.Drawing.Size(163, 20);
            this.PortConnectedStatus.TabIndex = 8;
            this.PortConnectedStatus.Text = "PortConnectedStatus";
            // 
            // CommandPalete
            // 
            this.CommandPalete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandPalete.Location = new System.Drawing.Point(3, 320);
            this.CommandPalete.MaxLength = 20;
            this.CommandPalete.Name = "CommandPalete";
            this.CommandPalete.Size = new System.Drawing.Size(274, 20);
            this.CommandPalete.TabIndex = 9;
            this.CommandPalete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandPalete_EnterPressed);
            // 
            // ClearTxRx
            // 
            this.ClearTxRx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearTxRx.Location = new System.Drawing.Point(283, 320);
            this.ClearTxRx.Name = "ClearTxRx";
            this.ClearTxRx.Size = new System.Drawing.Size(75, 20);
            this.ClearTxRx.TabIndex = 10;
            this.ClearTxRx.Text = "Clear";
            this.ClearTxRx.UseVisualStyleBackColor = true;
            this.ClearTxRx.Click += new System.EventHandler(this.ClearTxRx_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.DEBUG);
            this.tabControl1.Controls.Add(this.SPI);
            this.tabControl1.Controls.Add(this.LMX2594);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 369);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 11;
            // 
            // DEBUG
            // 
            this.DEBUG.Controls.Add(this.TxRx);
            this.DEBUG.Controls.Add(this.ClearTxRx);
            this.DEBUG.Controls.Add(this.OpenPort);
            this.DEBUG.Controls.Add(this.CommandPalete);
            this.DEBUG.Controls.Add(this.ClosePort);
            this.DEBUG.Controls.Add(this.PortConnectedStatus);
            this.DEBUG.Controls.Add(this.GetPorts);
            this.DEBUG.Controls.Add(this.PortList);
            this.DEBUG.Location = new System.Drawing.Point(4, 22);
            this.DEBUG.Name = "DEBUG";
            this.DEBUG.Padding = new System.Windows.Forms.Padding(3);
            this.DEBUG.Size = new System.Drawing.Size(364, 343);
            this.DEBUG.TabIndex = 0;
            this.DEBUG.Text = "DEBUG";
            this.DEBUG.UseVisualStyleBackColor = true;
            // 
            // SPI
            // 
            this.SPI.Controls.Add(this.DBG);
            this.SPI.Controls.Add(this.SPI_Send);
            this.SPI.Controls.Add(this.SPI_Clear);
            this.SPI.Controls.Add(this.label1);
            this.SPI.Location = new System.Drawing.Point(4, 22);
            this.SPI.Name = "SPI";
            this.SPI.Padding = new System.Windows.Forms.Padding(3);
            this.SPI.Size = new System.Drawing.Size(364, 343);
            this.SPI.TabIndex = 1;
            this.SPI.Text = "SPI";
            this.SPI.UseVisualStyleBackColor = true;
            this.SPI.Click += new System.EventHandler(this.SPI_Click);
            // 
            // DBG
            // 
            this.DBG.Location = new System.Drawing.Point(6, 124);
            this.DBG.MaxLength = 19;
            this.DBG.Name = "DBG";
            this.DBG.Size = new System.Drawing.Size(355, 43);
            this.DBG.TabIndex = 14;
            this.DBG.Text = "";
            // 
            // SPI_Send
            // 
            this.SPI_Send.Location = new System.Drawing.Point(6, 23);
            this.SPI_Send.MaxLength = 29;
            this.SPI_Send.Name = "SPI_Send";
            this.SPI_Send.Size = new System.Drawing.Size(355, 43);
            this.SPI_Send.TabIndex = 11;
            this.SPI_Send.Text = "";
            this.SPI_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SPI_Send_EnterPressed);
            // 
            // SPI_Clear
            // 
            this.SPI_Clear.Location = new System.Drawing.Point(6, 72);
            this.SPI_Clear.Name = "SPI_Clear";
            this.SPI_Clear.Size = new System.Drawing.Size(355, 31);
            this.SPI_Clear.TabIndex = 13;
            this.SPI_Clear.Text = "Clear";
            this.SPI_Clear.UseVisualStyleBackColor = true;
            this.SPI_Clear.Click += new System.EventHandler(this.SPI_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPI Max packet 10 bytes";
            // 
            // LMX2594
            // 
            this.LMX2594.Controls.Add(this.Status);
            this.LMX2594.Controls.Add(this.ClearHexLabel);
            this.LMX2594.Controls.Add(this.ClearHex);
            this.LMX2594.Controls.Add(this.Operate);
            this.LMX2594.Controls.Add(this.RegisterVal);
            this.LMX2594.Controls.Add(this.RegVal);
            this.LMX2594.Controls.Add(this.RegNo);
            this.LMX2594.Controls.Add(this.SPI_Read);
            this.LMX2594.Controls.Add(this.SPI_Write);
            this.LMX2594.Controls.Add(this.RegisterPrefix);
            this.LMX2594.Controls.Add(this.RegisterName);
            this.LMX2594.Location = new System.Drawing.Point(4, 22);
            this.LMX2594.Name = "LMX2594";
            this.LMX2594.Size = new System.Drawing.Size(364, 343);
            this.LMX2594.TabIndex = 2;
            this.LMX2594.Text = "LMX2594";
            this.LMX2594.UseVisualStyleBackColor = true;
            // 
            // RegisterName
            // 
            this.RegisterName.AutoSize = true;
            this.RegisterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterName.Location = new System.Drawing.Point(9, 12);
            this.RegisterName.Name = "RegisterName";
            this.RegisterName.Size = new System.Drawing.Size(81, 20);
            this.RegisterName.TabIndex = 1;
            this.RegisterName.Text = "RegName";
            // 
            // RegisterPrefix
            // 
            this.RegisterPrefix.AutoSize = true;
            this.RegisterPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterPrefix.Location = new System.Drawing.Point(9, 38);
            this.RegisterPrefix.Name = "RegisterPrefix";
            this.RegisterPrefix.Size = new System.Drawing.Size(21, 20);
            this.RegisterPrefix.TabIndex = 2;
            this.RegisterPrefix.Text = "R";
            // 
            // SPI_Write
            // 
            this.SPI_Write.AutoSize = true;
            this.SPI_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SPI_Write.Location = new System.Drawing.Point(184, 12);
            this.SPI_Write.Name = "SPI_Write";
            this.SPI_Write.Size = new System.Drawing.Size(65, 24);
            this.SPI_Write.TabIndex = 3;
            this.SPI_Write.Text = "Write";
            this.SPI_Write.UseVisualStyleBackColor = true;
            this.SPI_Write.CheckedChanged += new System.EventHandler(this.SPI_Write_CheckedChanged);
            // 
            // SPI_Read
            // 
            this.SPI_Read.AutoSize = true;
            this.SPI_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SPI_Read.Location = new System.Drawing.Point(184, 36);
            this.SPI_Read.Name = "SPI_Read";
            this.SPI_Read.Size = new System.Drawing.Size(67, 24);
            this.SPI_Read.TabIndex = 4;
            this.SPI_Read.Text = "Read";
            this.SPI_Read.UseVisualStyleBackColor = true;
            this.SPI_Read.CheckedChanged += new System.EventHandler(this.SPI_Read_CheckedChanged);
            // 
            // RegNo
            // 
            this.RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegNo.Location = new System.Drawing.Point(36, 35);
            this.RegNo.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.RegNo.Name = "RegNo";
            this.RegNo.Size = new System.Drawing.Size(54, 26);
            this.RegNo.TabIndex = 5;
            this.RegNo.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // RegVal
            // 
            this.RegVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegVal.Location = new System.Drawing.Point(106, 35);
            this.RegVal.Name = "RegVal";
            this.RegVal.Size = new System.Drawing.Size(61, 26);
            this.RegVal.TabIndex = 6;
            this.RegVal.Text = "00";
            // 
            // RegisterVal
            // 
            this.RegisterVal.AutoSize = true;
            this.RegisterVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegisterVal.Location = new System.Drawing.Point(105, 12);
            this.RegisterVal.Name = "RegisterVal";
            this.RegisterVal.Size = new System.Drawing.Size(62, 20);
            this.RegisterVal.TabIndex = 7;
            this.RegisterVal.Text = "RegVal";
            // 
            // Operate
            // 
            this.Operate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Operate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Operate.Location = new System.Drawing.Point(257, 12);
            this.Operate.Name = "Operate";
            this.Operate.Size = new System.Drawing.Size(99, 46);
            this.Operate.TabIndex = 8;
            this.Operate.Text = "Operate";
            this.Operate.UseVisualStyleBackColor = true;
            // 
            // ClearHex
            // 
            this.ClearHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClearHex.Location = new System.Drawing.Point(106, 76);
            this.ClearHex.MaxLength = 6;
            this.ClearHex.Name = "ClearHex";
            this.ClearHex.Size = new System.Drawing.Size(145, 26);
            this.ClearHex.TabIndex = 9;
            this.ClearHex.Text = "000000";
            // 
            // ClearHexLabel
            // 
            this.ClearHexLabel.AutoSize = true;
            this.ClearHexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClearHexLabel.Location = new System.Drawing.Point(8, 79);
            this.ClearHexLabel.Name = "ClearHexLabel";
            this.ClearHexLabel.Size = new System.Drawing.Size(74, 20);
            this.ClearHexLabel.TabIndex = 10;
            this.ClearHexLabel.Text = "ClearHex";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Status.Location = new System.Drawing.Point(257, 79);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 370);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VCP STM Terminal";
            this.tabControl1.ResumeLayout(false);
            this.DEBUG.ResumeLayout(false);
            this.DEBUG.PerformLayout();
            this.SPI.ResumeLayout(false);
            this.SPI.PerformLayout();
            this.LMX2594.ResumeLayout(false);
            this.LMX2594.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.RichTextBox TxRx;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Button GetPorts;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label PortConnectedStatus;
        private System.Windows.Forms.TextBox CommandPalete;
        private System.Windows.Forms.Button ClearTxRx;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DEBUG;
        private System.Windows.Forms.TabPage SPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SPI_Send;
        private System.Windows.Forms.Button SPI_Clear;
        private System.Windows.Forms.RichTextBox DBG;
        private System.Windows.Forms.TabPage LMX2594;
        private System.Windows.Forms.Label RegisterName;
        private System.Windows.Forms.CheckBox SPI_Read;
        private System.Windows.Forms.CheckBox SPI_Write;
        private System.Windows.Forms.Label RegisterPrefix;
        private System.Windows.Forms.NumericUpDown RegNo;
        private System.Windows.Forms.TextBox RegVal;
        private System.Windows.Forms.Button Operate;
        private System.Windows.Forms.Label RegisterVal;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label ClearHexLabel;
        private System.Windows.Forms.TextBox ClearHex;
    }
}

