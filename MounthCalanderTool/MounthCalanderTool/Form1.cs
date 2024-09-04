namespace MounthCalanderTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt1 = monthCalendar1.SelectionRange.Start;
            DateTime dt2 = monthCalendar1.SelectionRange.Start;
            label1.Text = dt1.ToString() + "\n" + dt2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(monthCalendar1.Visible)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }
    }
}
