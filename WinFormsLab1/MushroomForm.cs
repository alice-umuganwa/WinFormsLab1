
using System;
using System.Windows.Forms;

namespace WinFormsLab1
{
    public partial class MushroomForm : Form
    {
        private int currentQuestion = 0;

        private bool hasGills;
        private bool growsInForest;
        private bool hasRing;
        private bool hasConvexCup;

        public MushroomForm()
        {
            InitializeComponent();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            rdoGillsYes.Checked = false;
            rdoGillsNo.Checked = false;

            switch (currentQuestion)
            {
                case 0:
                    lblQuestion.Text = "Question 1: Does your mushroom have gills?";
                    break;

                case 1:
                    lblQuestion.Text = "Question 2: Does your mushroom grow in a forest?";
                    break;

                case 2:
                    lblQuestion.Text = "Question 3: Does your mushroom have a ring?";
                    break;

                case 3:
                    lblQuestion.Text = "Question 4: Does your mushroom have a convex cup?";
                    break;
            }
        }

        private void IdentifyMushroom()
        {
            if (hasGills && !growsInForest && hasRing && hasConvexCup)
            {
                ShowResult("Agaric Jaunissant");
            }
            else if (hasGills && growsInForest && hasRing && hasConvexCup)
            {
                ShowResult("Amanite tue-mouche");
            }
            else if (!hasGills && growsInForest && !hasRing && !hasConvexCup)
            {
                ShowResult("Cèpe de Bordeaux");
            }
            else if (hasGills && !growsInForest && hasRing && !hasConvexCup)
            {
                ShowResult("Coprin chevelu");
            }
            else if (hasGills && growsInForest && !hasRing && !hasConvexCup)
            {
                ShowResult("Girolle");
            }
            else if (hasGills && growsInForest && !hasRing && hasConvexCup)
            {
                ShowResult("Pied bleu");
            }
            else
            {
                ShowResult("No matching mushroom found.");
            }
        }

        private void ShowResult(string name)
        {
            lblResult.Text = "Your mushroom is: " + name;
            lblQuestion.Text = "Identification completed!";

            rdoGillsYes.Visible = false;
            rdoGillsNo.Visible = false;

            btnIdentify.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!rdoGillsYes.Checked && !rdoGillsNo.Checked)
            {
                MessageBox.Show("Please choose Yes or No.",
                    "Mushroom Identifier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool answer = rdoGillsYes.Checked;

            switch (currentQuestion)
            {
                case 0:
                    hasGills = answer;
                    break;

                case 1:
                    growsInForest = answer;
                    break;

                case 2:
                    hasRing = answer;
                    break;

                case 3:
                    hasConvexCup = answer;
                    IdentifyMushroom();
                    return;
            }

            currentQuestion++;

            ShowQuestion();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;

            hasGills = false;
            growsInForest = false;
            hasRing = false;
            hasConvexCup = false;

            lblResult.Text = "";

            rdoGillsYes.Visible = true;
            rdoGillsNo.Visible = true;

            btnIdentify.Enabled = true;

            ShowQuestion();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
