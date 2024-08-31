namespace ColorControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int alpha = (int)numericUpDownAlpha.Value;
                int red = (int)numericUpDownRed.Value;
                int green = (int)numericUpDownGreen.Value;
                int blue = (int)numericUpDownBlue.Value;
                pictureBox1.BackColor = Color.FromArgb(alpha, red, green, blue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
