namespace MessageBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMB_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Hello");
            label1.Text = dr.ToString();

            dr = MessageBox.Show("Hello", "Message");
            label1.Text = dr.ToString();

            dr = MessageBox.Show("Hello","message",MessageBoxButtons.YesNo);
            label1.Text = dr.ToString();

            dr = MessageBox.Show("Hello", "message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            label1.Text = dr.ToString();

            dr = MessageBox.Show("Hello", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            label1.Text = dr.ToString();

            dr = MessageBox.Show("السلام عليكم", "message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
            label1.Text = dr.ToString();

            dr = MessageBox.Show("السلام عليكم", "message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading,"help.txt");
            label1.Text = dr.ToString();




        }
    }
}
