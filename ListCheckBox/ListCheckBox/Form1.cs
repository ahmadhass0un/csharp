namespace ListCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CLBStuff.CheckedItems.Count; i++)
            {
                MessageBox.Show(CLBStuff.CheckedItems[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string thing = inputBox.Text;
            CLBStuff.Items.Add(thing);

        }

        private void CLBStuff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
