namespace checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stupidCheckbox.CheckState == CheckState.Checked)
            {
                MessageBox.Show("يعني أنت متأكد انك غبي!؟");
            }
            else if (stupidCheckbox.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("يعني أنت معتبر حالك مالك غبي!؟");
            }
            else
            {
                MessageBox.Show("أشو أنت يعني نص على نص!؟");
            }
        }
    }
}
