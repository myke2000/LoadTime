using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace LoadTime
{
   
    public partial class Form1 : Form
    {

        public int DaylightSavingsTime { get; set; }
        public bool SerialConnected = false;
        

        public Form1()
        {
            InitializeComponent();
            SoftwareVersion s= new SoftwareVersion();
            VersionValueLabel.Text = s.Version;
            GetDateTime();
            GetComPort();
            DSTradioButton.Checked = true;
            Debug.WriteLine("daylightsavings= "+DaylightSavingsTime.ToString());
            DateTime dow = DateTime.Now;

            Debug.WriteLine("day of week =" + ((int)dow.DayOfWeek+1)%7);


        }

        private void GetDateTime()
        {
            DateBox.Text = DateTime.Today.ToString("MM/dd/yyyy");
            TimeBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void GetComPort()
        {
            
            string[] ports=SerialPort.GetPortNames();
            for(int i=0;i<ports.Count();i++)
            {
                ComPortBox.Items.Add(ports[i]); 
            }
            if(ComPortBox.Items.Count > 0) { ComPortBox.SelectedIndex = 0; }
            


        }
        bool ComConnected = false;
        private void ConnectToCom()
        {
            if (!ComConnected)
            {


                if (!serialPort1.IsOpen)
                {

                    serialPort1.BaudRate = 9600;
                    serialPort1.ReadTimeout = 10;
                    //serialPort1.WriteTimeout = 500;
                    try
                    {

                        serialPort1.Open();
                        ConnectButton.Text = "DisConnect";
                        ConnectButton.BackColor = Color.Red;
                        ComConnected = true;
                        ComPortBox.Enabled = false;
                        //PauseRX = false;
                    }
                    catch 
                    {
                        MessageBox.Show("Com Port in use");

                    }

                }
                else
                {
                    MessageBox.Show("Com Port in use");
                }
            }
            else
            {
                
                serialPort1.Dispose();
                serialPort1.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("serial por=" + serialPort1.PortName );
            if (ComPortBox.Items.Count > 0)
            {
                if (ConnectButton.Text == "Connect")
                {
                    ConnectToCom();
                }
                else
                {
                    timer2.Enabled = true;

                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                    ConnectButton.Text = "Connect";
                    ConnectButton.BackColor = Color.White;
                    ComConnected = false;
                    ComPortBox.Enabled = true;
                    

                }
                
            }
            else
            {
                MessageBox.Show("No Com Ports!!", "error");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DataSendBox.Clear();
            if (serialPort1.IsOpen)
            {
                SerialConnected=true;
                WriteDateTimeToBoard(DateBox.Text,TimeBox.Text);
                
            }
            else
            {
                SerialConnected = false;
                MessageBox.Show("No com port connection","Error");
            }
           
        }

        bool resend = false;

        char[] dataToSend;
        private void WriteDateTimeToBoard(string date, string time)
        {

            string[] RawDate = date.Split('/');
            string day = RawDate[0];
            string month = RawDate[1];
            string year = RawDate[2];
            //Debug.WriteLine("day=" + day + " month="+month + " year=" + year);
            string[] RawTime = time.Split(':');
            string hour = RawTime[0];
            string minute = RawTime[1];
            string second = RawTime[2];

            int addOneSecond = Convert.ToInt32(second) + 1;
          
            DateTime dow = DateTime.Now;
            int DayOfWeek = (int)DateTime.Now.DayOfWeek+1%7;
            string DataString = day + month + year + "," + hour + minute + second + DaylightSavingsTime + DayOfWeek + '\r';
            Debug.WriteLine("day of week =" + dow.DayOfWeek);
           //// string DataString = day + month + year + "," + hour + minute + second + DaylightSavingsTime+ DayOfWeek+ '\r';
            string tohex = string.Format("{0:X}", DataString);

           
            dataToSend = DataString.ToCharArray();

            DataSendBox.Clear();
            //System.Threading.Sleep(1);
            try
            {
                for(int i=0;i<dataToSend.Length;i++)
                {

                    serialPort1.Write(dataToSend, i, 1);
                    
                }
                DataSendBox.Text = DataString;

                CharCountValueLabel.Text = dataToSend.Length.ToString();

                DispHex(DataString);
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDateTime();
            
        }

        private void ComPortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComPortBox.Items.Count > 0)
            {
                if (ConnectButton.Text == "Connect")
                {
                    serialPort1.PortName = ComPortBox.SelectedItem.ToString();
                }

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
                if (InvokeRequired)
                {

                    SerialRecvBox.Invoke(new MethodInvoker(delegate
                    {
                        SerialRecvBox.AppendText(serialPort1.ReadExisting());

                    }));

                }
                else
                {
                    SerialRecvBox.AppendText(serialPort1.ReadExisting());

                }
           
           

        }

       

        private void SerialRecvBox_TextChanged(object sender, EventArgs e)
        {
            
            SerialRecvBox.ScrollToCaret();
        }

        private void ClearRxTextButton_Click(object sender, EventArgs e)
        {
            SerialRecvBox.Clear();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if(ConnectButton.Text == "DisConnect")
            {
                serialPort1.Write(sendtextbox.Text);
                DataSendBox.Text = sendtextbox.Text;
                DispHex(DataSendBox.Text);
            }
            else
            {
                MessageBox.Show("com not connected", "error");
            }
            
        }

        private void DispHex(string s)
        {
            foreach (char letter in s)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(letter);
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = String.Format("{0:X2}", value);
                if (value != '\r')
                {
                    richTextBox1.AppendText(hexOutput);
                }
                else
                {
                    richTextBox1.AppendText(hexOutput);
                    richTextBox1.AppendText("\r");
                }

                richTextBox1.ScrollToCaret();
            }
        }

        private void SendCRbutton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "DisConnect")
            {
                string SendCR = "\r";
                DispHex(SendCR.ToString());

                serialPort1.Write("\r");
                DataSendBox.Text = string.Format("{0:X}","\r");
            }
            else
            {
                MessageBox.Show("com not connected", "error");
            }
        }

       
      

        private void timer2_Tick(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer2.Enabled = false;
        }

       

        private void CSTradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            //set Daylight to CST =6
            if(CSTradiobutton.Checked)
            {
                DaylightSavingsTime = 6;
                DSTradioButton.Checked = false;
                
            }
           
            
        }

        private void DSTradioButton_CheckedChanged(object sender, EventArgs e)
        {
            //set Daylight to DST =5
            if(DSTradioButton.Checked)
            {
                DaylightSavingsTime = 5;
                CSTradiobutton.Checked = false;
               
            }
            
            
        }


    }
}
