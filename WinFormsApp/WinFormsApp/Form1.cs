namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("hello world!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello, world!");
            Environment.Exit(0);
        }
    }
}
