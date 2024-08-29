using System.IO;
namespace FileCopier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();

            string f1 = "";
            string f2 = "";

            if (dr == DialogResult.OK)
            {
                if(File.Exists(ofd.FileName))
                {
                    f1 = ofd.FileName;

                }
                else
                {
                    MessageBox.Show("File not found");
                    return;
                }

            }

            SaveFileDialog sfd = new SaveFileDialog();
            string FileName =Path.GetFileName(f1);
            sfd.FileName = FileName;
            dr = sfd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                f2 = sfd.FileName;
            }
            else
            {
                MessageBox.Show("Error!");
                return ;
            }

            File.Copy(f1, f2);

        }

    }
}