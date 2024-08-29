namespace Times
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left >= 1000)
            { 
                timer1.Enabled = false;
            }
            pictureBox1.Left += 50;

        }
    }
}
