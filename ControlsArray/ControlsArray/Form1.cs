namespace ControlsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            TextBox txt = new TextBox();
            CheckBox chb = new CheckBox();
            RadioButton rdo = new RadioButton();
            Button btn = new Button();

            lbl.Text = "test";
            chb.Text = "test";
            rdo.Text = "test";
            btn.Text = "test";

            lbl.AutoSize = true;
            txt.AutoSize = true;
            chb.AutoSize = true;
            rdo.AutoSize = true;
            btn.AutoSize = true;



            lbl.Location = new Point(20, 0);
            txt.Location = new Point(20, 45);
            chb.Location = new Point(20, 80);
            rdo.Location = new Point(20, 120);
            btn.Location = new Point(20, 160);


            Control[] controls = { lbl, txt, chb, rdo, btn };
            Controls.AddRange(controls);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                MessageBox.Show(c.Text);
            }


        }
    }
}
