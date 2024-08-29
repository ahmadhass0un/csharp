using System.IO;
using System.Linq.Expressions;
namespace DataManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text.Trim() == "" || textBoxAddress.Text.Trim() == "" || textBoxName.Text.Trim() == "")
                {
                    MessageBox.Show("Missing data enter all the information");
                }
                else
                {
                    StreamReader srCheck = new StreamReader("Data.txt");
                    string allData = srCheck.ReadToEnd();
                    srCheck.Close();
                    if (allData.Contains(textBoxID.Text + ";"))
                    {
                        MessageBox.Show("replicated ID, Please change it.");
                        textBoxID.Focus();
                        textBoxID.SelectAll();
                    }
                    else
                    {
                        StreamWriter sw = new StreamWriter("Data.txt", true);
                        string strperson = textBoxID.Text + ";"
                                         + textBoxName.Text + ";"
                                         + textBoxAddress.Text + ";";
                        sw.WriteLine(strperson);
                        sw.Close();
                        if (!Directory.Exists("img"))
                        {
                            Directory.CreateDirectory("img");
                        }
                        pictureBox1.Image.Save("img/" + textBoxID.Text + ".jpg");
                        MessageBox.Show("Person Added");
                        foreach (Control c in this.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                        }
                        pictureBox1.Image = null;
                        textBoxID.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }


        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an ID");
                textBoxID.Focus();
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader("Data.txt"))
                    {
                        string line;
                        bool found = false;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] arrLine = line.Split(';');
                            if (arrLine.Length >= 3 && arrLine[0] == textBoxID.Text)
                            {
                                found = true;
                                textBoxID.Text = arrLine[0];
                                textBoxName.Text = arrLine[1];
                                textBoxAddress.Text = arrLine[2];
                                string MyPath = "img/" + arrLine[0] + ".jpg";
                                if (File.Exists(MyPath))
                                {
                                    pictureBox1.Image = Image.FromFile(MyPath);
                                }
                                break;
                            }
                        }

                        if (!found)
                        {
                            MessageBox.Show("Person not found");
                            textBoxID.Focus();
                            textBoxID.SelectAll();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }


        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            Form FrmShowAll = new Form();
            TextBox textBoxShow = new TextBox();
            FrmShowAll.StartPosition = FormStartPosition.CenterScreen;
            FrmShowAll.Font = this.Font;
            FrmShowAll.Icon = this.Icon;
            FrmShowAll.Site = this.Site;
            FrmShowAll.Text = "All data";
            textBoxShow.Multiline = true;
            textBoxShow.Dock = DockStyle.Fill;
            FrmShowAll.Controls.Add(textBoxShow);
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string StrAllData = sr.ReadToEnd();
                sr.Close();
                textBoxShow.Text = StrAllData;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


            FrmShowAll.ShowDialog();
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*gif;*bmp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);



            }
        }

        private void buttonShowAllWithImages_Click(object sender, EventArgs e)
        {
            Form FrmShowAll = new Form();
            FrmShowAll.StartPosition = FormStartPosition.CenterScreen;
            FrmShowAll.Font = this.Font;
            FrmShowAll.Icon = this.Icon;
            FrmShowAll.Site = this.Site;
            FrmShowAll.Height += 300;
            FrmShowAll.Width += 400;
            FrmShowAll.BackColor = this.BackColor;
            FrmShowAll.Text = "All data with images";
            FrmShowAll.AutoScroll = true;
            int top = 10;
            try
            {
                StreamReader sr = new StreamReader("Data.txt");
                string line;
                do
                {
                    line = sr.ReadLine();
                    if(line != null)
                    {
                        TextBox textBox = new TextBox();
                        PictureBox pictureBox = new PictureBox();
                        textBox.Width = 300;
                        textBox.Top = top;
                        textBox.Text = line;
                        pictureBox.Left = 305;
                        pictureBox.Top = top;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Size = new Size(150, 150);
                        string ImgPath = "img/" + line.Split(';')[0] + ".jpg";
                        if(File.Exists(ImgPath))
                        {
                            pictureBox.Image = Image.FromFile(ImgPath);
                        }
                        FrmShowAll.Controls.Add(textBox);
                        FrmShowAll.Controls.Add(pictureBox);
                        top += 155;
                    }
                } while (line != null);
                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }


            FrmShowAll.ShowDialog();
        }
    }
}