namespace ColorDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = color.ShowDialog();
            if(dr == DialogResult.OK)
            {
                labelColor.Text = color.Color.Name;
                labelRGB.Text = color.Color.A + "..;"
                    + color.Color.R + ";"
                    + color.Color.G + ";"
                    + color.Color.B + ";";
                pictureBox1.BackColor = color.Color;
            }



        }
    }
}
