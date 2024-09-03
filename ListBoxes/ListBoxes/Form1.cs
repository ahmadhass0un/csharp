namespace ListBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCity.Items.Add(textBox1.Text);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listCity.Items.Remove(textBox1.Text);
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            listCity.Items.Clear();
        }

        private void buttonShowSelected_Click(object sender, EventArgs e)
        {
            textBox1.Text = listCity.SelectedItem.ToString();
        }
    }
}
