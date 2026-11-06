
using System;
using System.Windows.Forms;

namespace WinFormsLab1
{
    public partial class chooseform : Form
    {
        public chooseform()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Bicycle_Rental bicycleForm = new Bicycle_Rental();

            this.Hide();

            DialogResult result = bicycleForm.ShowDialog();

            if (result == DialogResult.Abort)
            {
                GoToLogin();
            }
            else
            {
                this.Show();
            }
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroomForm = new MushroomForm();

            this.Hide();

            mushroomForm.ShowDialog();

            this.Show();
        }

        // Return to Login Form
        private void GoToLogin()
        {
            Form1 login = new Form1();

            login.Show();

            this.Close();
        }

        private void chooseform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
