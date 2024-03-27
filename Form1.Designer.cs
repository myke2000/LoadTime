namespace LoadTime
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
            this.components = new System.ComponentModel.Container();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DataSendBox = new System.Windows.Forms.TextBox();
            this.DataSentLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DebugBox = new System.Windows.Forms.GroupBox();
            this.VersionValueLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CharCountValueLabel = new System.Windows.Forms.Label();
            this.CharCountLabel = new System.Windows.Forms.Label();
            this.SerialRecvBox = new System.Windows.Forms.TextBox();
            this.ClearRxTextButton = new System.Windows.Forms.Button();
            this.sendtextbox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.SendCRbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HexsendLabel = new System.Windows.Forms.Label();
            this.RXlabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DSTradioButton = new System.Windows.Forms.RadioButton();
            this.CSTradiobutton = new System.Windows.Forms.RadioButton();
            this.DebugBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(13, 9);
            this.ComPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(75, 20);
            this.ComPortLabel.TabIndex = 0;
            this.ComPortLabel.Text = "ComPort:";
            // 
            // serialPort1
            // 
            this.serialPort1.DiscardNull = true;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.WriteTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ComPortBox
            // 
            this.ComPortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Location = new System.Drawing.Point(85, 6);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(121, 28);
            this.ComPortBox.TabIndex = 1;
            this.ComPortBox.SelectedIndexChanged += new System.EventHandler(this.ComPortBox_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(212, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(169, 28);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(13, 44);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 20);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(85, 41);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(121, 26);
            this.DateBox.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(212, 44);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(47, 20);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Time:";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(260, 40);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(121, 26);
            this.TimeBox.TabIndex = 6;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(17, 106);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(364, 33);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load Date/Time";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // DataSendBox
            // 
            this.DataSendBox.Location = new System.Drawing.Point(105, 146);
            this.DataSendBox.Name = "DataSendBox";
            this.DataSendBox.Size = new System.Drawing.Size(276, 26);
            this.DataSendBox.TabIndex = 8;
            // 
            // DataSentLabel
            // 
            this.DataSentLabel.AutoSize = true;
            this.DataSentLabel.Location = new System.Drawing.Point(13, 149);
            this.DataSentLabel.Name = "DataSentLabel";
            this.DataSentLabel.Size = new System.Drawing.Size(86, 20);
            this.DataSentLabel.TabIndex = 9;
            this.DataSentLabel.Text = "Data Sent:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(17, 178);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(583, 37);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DebugBox
            // 
            this.DebugBox.Controls.Add(this.VersionValueLabel);
            this.DebugBox.Controls.Add(this.VersionLabel);
            this.DebugBox.Controls.Add(this.CharCountValueLabel);
            this.DebugBox.Controls.Add(this.CharCountLabel);
            this.DebugBox.Location = new System.Drawing.Point(388, 6);
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(209, 166);
            this.DebugBox.TabIndex = 11;
            this.DebugBox.TabStop = false;
            this.DebugBox.Text = "Debug";
            // 
            // VersionValueLabel
            // 
            this.VersionValueLabel.AutoSize = true;
            this.VersionValueLabel.Location = new System.Drawing.Point(86, 26);
            this.VersionValueLabel.Name = "VersionValueLabel";
            this.VersionValueLabel.Size = new System.Drawing.Size(18, 20);
            this.VersionValueLabel.TabIndex = 8;
            this.VersionValueLabel.Text = "0";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(19, 26);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(67, 20);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Version:";
            // 
            // CharCountValueLabel
            // 
            this.CharCountValueLabel.AutoSize = true;
            this.CharCountValueLabel.Location = new System.Drawing.Point(106, 137);
            this.CharCountValueLabel.Name = "CharCountValueLabel";
            this.CharCountValueLabel.Size = new System.Drawing.Size(18, 20);
            this.CharCountValueLabel.TabIndex = 1;
            this.CharCountValueLabel.Text = "0";
            // 
            // CharCountLabel
            // 
            this.CharCountLabel.AutoSize = true;
            this.CharCountLabel.Location = new System.Drawing.Point(6, 137);
            this.CharCountLabel.Name = "CharCountLabel";
            this.CharCountLabel.Size = new System.Drawing.Size(94, 20);
            this.CharCountLabel.TabIndex = 0;
            this.CharCountLabel.Text = "Char Count:";
            // 
            // SerialRecvBox
            // 
            this.SerialRecvBox.Location = new System.Drawing.Point(17, 464);
            this.SerialRecvBox.Multiline = true;
            this.SerialRecvBox.Name = "SerialRecvBox";
            this.SerialRecvBox.ReadOnly = true;
            this.SerialRecvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SerialRecvBox.Size = new System.Drawing.Size(580, 209);
            this.SerialRecvBox.TabIndex = 12;
            this.SerialRecvBox.TextChanged += new System.EventHandler(this.SerialRecvBox_TextChanged);
            // 
            // ClearRxTextButton
            // 
            this.ClearRxTextButton.Location = new System.Drawing.Point(12, 699);
            this.ClearRxTextButton.Name = "ClearRxTextButton";
            this.ClearRxTextButton.Size = new System.Drawing.Size(118, 34);
            this.ClearRxTextButton.TabIndex = 13;
            this.ClearRxTextButton.Text = "Clear RX text";
            this.ClearRxTextButton.UseVisualStyleBackColor = true;
            this.ClearRxTextButton.Click += new System.EventHandler(this.ClearRxTextButton_Click);
            // 
            // sendtextbox
            // 
            this.sendtextbox.Location = new System.Drawing.Point(17, 221);
            this.sendtextbox.Name = "sendtextbox";
            this.sendtextbox.Size = new System.Drawing.Size(276, 26);
            this.sendtextbox.TabIndex = 14;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(299, 221);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(169, 28);
            this.sendbutton.TabIndex = 15;
            this.sendbutton.Text = "send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // SendCRbutton
            // 
            this.SendCRbutton.Location = new System.Drawing.Point(474, 221);
            this.SendCRbutton.Name = "SendCRbutton";
            this.SendCRbutton.Size = new System.Drawing.Size(123, 28);
            this.SendCRbutton.TabIndex = 16;
            this.SendCRbutton.Text = "CR";
            this.SendCRbutton.UseVisualStyleBackColor = true;
            this.SendCRbutton.Click += new System.EventHandler(this.SendCRbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 273);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(580, 160);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // HexsendLabel
            // 
            this.HexsendLabel.AutoSize = true;
            this.HexsendLabel.Location = new System.Drawing.Point(17, 250);
            this.HexsendLabel.Name = "HexsendLabel";
            this.HexsendLabel.Size = new System.Drawing.Size(78, 20);
            this.HexsendLabel.TabIndex = 18;
            this.HexsendLabel.Text = "Hex value";
            // 
            // RXlabel
            // 
            this.RXlabel.AutoSize = true;
            this.RXlabel.Location = new System.Drawing.Point(17, 441);
            this.RXlabel.Name = "RXlabel";
            this.RXlabel.Size = new System.Drawing.Size(75, 20);
            this.RXlabel.TabIndex = 19;
            this.RXlabel.Text = "RX Data:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DSTradioButton
            // 
            this.DSTradioButton.AutoSize = true;
            this.DSTradioButton.Location = new System.Drawing.Point(21, 76);
            this.DSTradioButton.Name = "DSTradioButton";
            this.DSTradioButton.Size = new System.Drawing.Size(78, 24);
            this.DSTradioButton.TabIndex = 21;
            this.DSTradioButton.TabStop = true;
            this.DSTradioButton.Text = "DST(5)";
            this.DSTradioButton.UseVisualStyleBackColor = true;
            this.DSTradioButton.CheckedChanged += new System.EventHandler(this.DSTradioButton_CheckedChanged);
            // 
            // CSTradiobutton
            // 
            this.CSTradiobutton.AutoSize = true;
            this.CSTradiobutton.Location = new System.Drawing.Point(147, 76);
            this.CSTradiobutton.Name = "CSTradiobutton";
            this.CSTradiobutton.Size = new System.Drawing.Size(77, 24);
            this.CSTradiobutton.TabIndex = 22;
            this.CSTradiobutton.TabStop = true;
            this.CSTradiobutton.Text = "CST(6)";
            this.CSTradiobutton.UseVisualStyleBackColor = true;
            this.CSTradiobutton.CheckedChanged += new System.EventHandler(this.CSTradiobutton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 739);
            this.ControlBox = false;
            this.Controls.Add(this.CSTradiobutton);
            this.Controls.Add(this.DSTradioButton);
            this.Controls.Add(this.RXlabel);
            this.Controls.Add(this.HexsendLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SendCRbutton);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.sendtextbox);
            this.Controls.Add(this.ClearRxTextButton);
            this.Controls.Add(this.SerialRecvBox);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DataSentLabel);
            this.Controls.Add(this.DataSendBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ComPortBox);
            this.Controls.Add(this.ComPortLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(628, 780);
            this.MinimumSize = new System.Drawing.Size(628, 257);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Time Loader";
            this.DebugBox.ResumeLayout(false);
            this.DebugBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComPortLabel;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox DataSendBox;
        private System.Windows.Forms.Label DataSentLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox DebugBox;
        private System.Windows.Forms.Label CharCountValueLabel;
        private System.Windows.Forms.Label CharCountLabel;
        private System.Windows.Forms.TextBox SerialRecvBox;
        private System.Windows.Forms.Button ClearRxTextButton;
        private System.Windows.Forms.TextBox sendtextbox;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button SendCRbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label HexsendLabel;
        private System.Windows.Forms.Label RXlabel;
        private System.Windows.Forms.Label VersionValueLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton DSTradioButton;
        private System.Windows.Forms.RadioButton CSTradiobutton;
    }
}

