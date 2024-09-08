namespace TextBoxMasked
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text.Contains(" "))
            {
                MessageBox.Show("Enter With the date format dd/mm/yyyy");
            }
            MessageBox.Show(maskedTextBox1.Text);
        }
    }
}
