namespace RemoveControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //this.Controls[1].Dispose();
            if (this.Controls["labelHeader"] != null)
            {
                this.Controls["labelHeader"].Dispose();
            }
        }
    }
}
