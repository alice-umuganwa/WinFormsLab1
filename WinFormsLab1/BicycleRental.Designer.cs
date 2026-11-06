using System.Drawing;
using System.Windows.Forms;

namespace WinFormsLab1
{
    partial class Bicycle_Rental
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            btnLogout = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 46);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Bicycle Rental";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(160, 113);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(102, 25);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting time";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(160, 164);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(107, 25);
            lblEnd.TabIndex = 2;
            lblEnd.Text = "Ending time";
            // 
            // txtStart
            // 
            txtStart.Location = new Point(344, 117);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(150, 31);
            txtStart.TabIndex = 3;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(344, 161);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(150, 31);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(135, 250);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(148, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "calculate price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(370, 252);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(160, 330);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(200, 25);
            lblResult.TabIndex = 7;
            lblResult.Text = "Total rental fee: 0 RWF";
            // 
            // Bicycle_Rental
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnLogout);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(label1);
            Name = "Bicycle_Rental";
            Text = "Bicycle Rental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStart;
        private Label lblEnd;
        private TextBox txtStart;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Button btnLogout;
        private Label lblResult;
    }
}