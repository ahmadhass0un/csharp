namespace ProggressBars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            progressBar1.Value += 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 25;
        }
    }
}
