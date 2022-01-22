using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Custom : UserControl
    {
        public Custom()
        {
            InitializeComponent();
        }

        private void Custom_Load(object sender, EventArgs e)
        {
            LHour.Text = DateTime.Now.ToString("HH:mm");
            LSeconds.Text = DateTime.Now.ToString("ss");
            LCalendar.Text = DateTime.Now.ToString("MMM - dd - yyyy");
            TCalendar.Start();

        }
    }
}
