using System.IO;
namespace OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OFD.Title = "Open File";
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OFD.ShowDialog();
            textBoxPath.Text = OFD.FileName;
            textBoxName.Text = Path.GetFileName(textBoxPath.Text);
            textBoxExtFile.Text = Path.GetExtension(textBoxPath.Text);
            
            

        }
    }
}
