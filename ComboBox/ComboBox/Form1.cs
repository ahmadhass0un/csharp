namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                comboBox.Items.Add(comboBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox.");
            }
        }
    }
}
