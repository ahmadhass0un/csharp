namespace hellofourm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = namePlace.Text;
            if (name == "هون")
            {
                MessageBox.Show("لك كتوب اسمك فوق");
            }
            else
            {
                helloname.Text = "أهلين يا " + name + " أبو الشباب";
            }
            
        }

        private void lable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
