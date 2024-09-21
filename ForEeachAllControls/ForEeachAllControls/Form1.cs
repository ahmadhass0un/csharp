namespace ForEeachAllControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        textBox1.Text = c.Text;
                    }
                }
            }


        }
    }
}
