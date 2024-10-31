using static System.Net.Mime.MediaTypeNames;

namespace FlowLayoutPaneL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddcontrols_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Size = new Size(300, 300); 
            flp.Location = new Point(220, 30);
            flp.AutoScroll = true; 
            flp.FlowDirection = FlowDirection.TopDown;

            TextBox txt1 = new TextBox();
            TextBox txt2 = new TextBox();
            TextBox txt3 = new TextBox();
            TextBox txt4 = new TextBox();
            TextBox txt5 = new TextBox();

            CheckBox chk1 = new CheckBox();
            CheckBox chk2 = new CheckBox();
            CheckBox chk3 = new CheckBox();
            CheckBox chk4 = new CheckBox();
            CheckBox chk5 = new CheckBox();

            Control[] allc = { txt1, txt2, txt3, txt4, txt5, chk1, chk2, chk3, chk4, chk5 };

            flp.Controls.AddRange(allc);
            this.Controls.Add(flp);
        }
    }
}
