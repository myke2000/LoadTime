namespace LoadTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SetTimeButton = new Button();
            CloseButton = new Button();
            label1 = new Label();
            DataSentBox = new TextBox();
            ComPortBox = new ComboBox();
            label2 = new Label();
            ConnectButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            DateLabel = new Label();
            TimeLabel = new Label();
            DateBox = new TextBox();
            TimeBox = new TextBox();
            SuspendLayout();
            // 
            // SetTimeButton
            // 
            SetTimeButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SetTimeButton.Location = new Point(13, 199);
            SetTimeButton.Name = "SetTimeButton";
            SetTimeButton.Size = new Size(256, 33);
            SetTimeButton.TabIndex = 1;
            SetTimeButton.Text = "Set Time";
            SetTimeButton.UseVisualStyleBackColor = true;
            SetTimeButton.Click += SetTimeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(13, 288);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(256, 33);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(82, 18);
            label1.TabIndex = 3;
            label1.Text = "Data Sent:";
            // 
            // DataSentBox
            // 
            DataSentBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataSentBox.Location = new Point(14, 256);
            DataSentBox.Name = "DataSentBox";
            DataSentBox.Size = new Size(257, 26);
            DataSentBox.TabIndex = 4;
            // 
            // ComPortBox
            // 
            ComPortBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComPortBox.FormattingEnabled = true;
            ComPortBox.Location = new Point(11, 32);
            ComPortBox.Name = "ComPortBox";
            ComPortBox.Size = new Size(258, 26);
            ComPortBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 6;
            label2.Text = "Com Port:";
            // 
            // ConnectButton
            // 
            ConnectButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConnectButton.Location = new Point(10, 61);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(256, 33);
            ConnectButton.TabIndex = 7;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(11, 98);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(46, 18);
            DateLabel.TabIndex = 8;
            DateLabel.Text = "Date:";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.Location = new Point(12, 146);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(46, 18);
            TimeLabel.TabIndex = 9;
            TimeLabel.Text = "Time:";
            // 
            // DateBox
            // 
            DateBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateBox.Location = new Point(15, 120);
            DateBox.Name = "DateBox";
            DateBox.Size = new Size(253, 26);
            DateBox.TabIndex = 10;
            DateBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TimeBox
            // 
            TimeBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimeBox.Location = new Point(15, 167);
            TimeBox.Name = "TimeBox";
            TimeBox.Size = new Size(251, 26);
            TimeBox.TabIndex = 11;
            TimeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 328);
            Controls.Add(TimeBox);
            Controls.Add(DateBox);
            Controls.Add(TimeLabel);
            Controls.Add(DateLabel);
            Controls.Add(ConnectButton);
            Controls.Add(label2);
            Controls.Add(ComPortBox);
            Controls.Add(DataSentBox);
            Controls.Add(label1);
            Controls.Add(CloseButton);
            Controls.Add(SetTimeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SetTimeButton;
        private Button CloseButton;
        private Label label1;
        private TextBox DataSentBox;
        private ComboBox ComPortBox;
        private Label label2;
        private Button ConnectButton;
        private System.Windows.Forms.Timer timer1;
        private Label DateLabel;
        private Label TimeLabel;
        private TextBox DateBox;
        private TextBox TimeBox;
    }
}