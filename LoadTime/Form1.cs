namespace LoadTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            timer1.Start();
        }

        private void GetDateTime()
        {
            DateBox.Text = DateTime.Today.ToString("yyyy/MM/dd");
            TimeBox.Text = DateTime.Now.ToString("HH:mm");
        }

        private void SetTimeButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDateTime();
        }
    }
}