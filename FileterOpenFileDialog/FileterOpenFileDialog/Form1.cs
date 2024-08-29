namespace FileterOpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "images|*.jpg;*.bmp;*.png|text files|*.txt|All files|*.*";
            ofd.FilterIndex = 3;
            ofd.ShowDialog();
        }
    }
}
