using System;
using System.Windows.Forms;

namespace WinFormsLab1
{
    public partial class Bicycle_Rental : Form
    {
        public Bicycle_Rental()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start, end;

            if (!int.TryParse(txtStart.Text, out start) ||
                !int.TryParse(txtEnd.Text, out end))
            {
                lblResult.Text = "Invalid input!";
                return;
            }

            if (start < 0 || start > 23 || end < 1 || end > 24 || start >= end)
            {
                lblResult.Text = "Invalid input!";
                return;
            }

            int total = 0;
            int hour = start;

            while (hour < end)
            {
                int rate;

                if (hour >= 0 && hour < 7)
                    rate = 500;
                else if (hour >= 7 && hour < 14)
                    rate = 1000;
                else if (hour >= 14 && hour < 19)
                    rate = 1500;
                else if (hour >= 19 && hour < 21)
                    rate = 1000;
                else
                    rate = 500;

                total = total + rate;
                hour++;
            }

            lblResult.Text = "Total rental fee: " + total + " RWF";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}