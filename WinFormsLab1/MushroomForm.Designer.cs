
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLab1
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblQuestion = new Label();
            rdoGillsYes = new RadioButton();
            rdoGillsNo = new RadioButton();
            btnIdentify = new Button();
            btnRestart = new Button();
            btnLogout = new Button();
            lblResult = new Label();

            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Arial",
                16F,
                System.Drawing.FontStyle.Bold
            );
            lblTitle.Location = new Point(250, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 30);
            lblTitle.Text = "Mushroom Identifier";

            // lblQuestion
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new System.Drawing.Font(
                "Arial",
                11F,
                System.Drawing.FontStyle.Regular
            );
            lblQuestion.Location = new Point(148, 110);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(500, 30);
            lblQuestion.Text = "Question 1: Does your mushroom have gills?";

            // rdoGillsYes
            rdoGillsYes.AutoSize = true;
            rdoGillsYes.Location = new Point(180, 165);
            rdoGillsYes.Name = "rdoGillsYes";
            rdoGillsYes.Size = new Size(63, 29);
            rdoGillsYes.Text = "Yes";

            // rdoGillsNo
            rdoGillsNo.AutoSize = true;
            rdoGillsNo.Location = new Point(280, 165);
            rdoGillsNo.Name = "rdoGillsNo";
            rdoGillsNo.Size = new Size(61, 29);
            rdoGillsNo.Text = "No";

            // btnIdentify
            btnIdentify.Location = new Point(148, 350);
            btnIdentify.Name = "btnIdentify";
            btnIdentify.Size = new Size(110, 34);
            btnIdentify.Text = "Next";
            btnIdentify.Click += btnNext_Click;

            // btnRestart
            btnRestart.Location = new Point(300, 350);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(110, 34);
            btnRestart.Text = "Restart";
            btnRestart.Click += btnRestart_Click;

            // btnLogout
            btnLogout.Location = new Point(443, 350);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 34);
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;

            // lblResult
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font(
                "Arial",
                11F,
                System.Drawing.FontStyle.Bold
            );
            lblResult.Location = new Point(148, 260);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(450, 30);
            lblResult.Text = "";

            // MushroomForm
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(lblTitle);
            Controls.Add(lblQuestion);
            Controls.Add(rdoGillsYes);
            Controls.Add(rdoGillsNo);
            Controls.Add(btnIdentify);
            Controls.Add(btnRestart);
            Controls.Add(btnLogout);
            Controls.Add(lblResult);

            Name = "MushroomForm";
            Text = "Mushroom Identifier";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestion;
        private RadioButton rdoGillsYes;
        private RadioButton rdoGillsNo;
        private Button btnIdentify;
        private Button btnRestart;
        private Button btnLogout;
        private Label lblResult;
    }
}
