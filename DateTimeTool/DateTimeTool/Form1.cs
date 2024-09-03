namespace DateTimeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker2.Value.ToString();

        }

        private void buttonGO2_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
