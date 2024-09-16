namespace PanelAndGroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) /2;
            int y = (this.Height - panel1.Height) /2;
            panel1.Location = new Point(x, y);
        }
    }
}
