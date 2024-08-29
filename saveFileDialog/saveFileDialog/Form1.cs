using System.Net.Mail;
using System.IO;

namespace saveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Title = "Save file";
            SFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SFD.FileName = textBoxFileName.Text+".txt";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                string strpath = SFD.FileName;
                if (Path.GetExtension(SFD.FileName).ToLower() != ".txt")
                    {
                    strpath += ".txt";
                    StreamWriter sw = new StreamWriter(strpath);
                    sw.WriteLine(textBoxText.Text);
                    sw.Close();
                    }
            }
        }
    }
}
