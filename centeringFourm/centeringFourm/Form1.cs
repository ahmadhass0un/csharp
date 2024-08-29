namespace centeringFourm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetFourm()
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) /2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) /2;
            this.Location = new Point(x, y);
            this.Size = new Size(x,y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetFourm();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            SetFourm();
        }
    }
}
