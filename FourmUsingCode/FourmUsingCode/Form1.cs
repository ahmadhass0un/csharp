namespace FourmUsingCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            TextBox textBox = new TextBox();
            Button button = new Button();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new Size(600,500);
            textBox.Location = new Point(200,100);
            button.Text = "OK";
            button.Location = new Point(200, 125);
            frm.Controls.Add(button);
            frm.Controls.Add(textBox);
            frm.Show();
        }
    }
}
