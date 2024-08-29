namespace BtnWithTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            textBox.Visible = true;
            textBox.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox.Visible = false;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            textBox.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = textBox.Text;
            MessageBox.Show("hello " + name + "!");
        }
    }
}
