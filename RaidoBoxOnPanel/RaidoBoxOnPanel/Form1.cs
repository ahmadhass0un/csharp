namespace RaidoBoxOnPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                MessageBox.Show("Male");
            }
            else if (radioButtonFemale.Checked)
            {
                MessageBox.Show("Female");
            }
        }
    }
}
