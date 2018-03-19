namespace Pseudocode_Master
{
    partial class LearningDoWhile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.detalii = new System.Windows.Forms.Button();
            this.general = new System.Windows.Forms.Label();
            this.syntax_box = new System.Windows.Forms.RichTextBox();
            this.practice_box = new System.Windows.Forms.RichTextBox();
            this.check = new System.Windows.Forms.Button();
            this.explain_box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // detalii
            // 
            this.detalii.Location = new System.Drawing.Point(795, 7);
            this.detalii.Name = "detalii";
            this.detalii.Size = new System.Drawing.Size(125, 34);
            this.detalii.TabIndex = 37;
            this.detalii.Text = "nu";
            this.detalii.UseVisualStyleBackColor = true;
            this.detalii.Click += new System.EventHandler(this.detalii_Click);
            // 
            // general
            // 
            this.general.AutoSize = true;
            this.general.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.general.Location = new System.Drawing.Point(12, 13);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(34, 25);
            this.general.TabIndex = 36;
            this.general.Text = "da";
            // 
            // syntax_box
            // 
            this.syntax_box.BackColor = System.Drawing.Color.PaleGreen;
            this.syntax_box.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.syntax_box.ForeColor = System.Drawing.Color.MidnightBlue;
            this.syntax_box.Location = new System.Drawing.Point(12, 46);
            this.syntax_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.syntax_box.Name = "syntax_box";
            this.syntax_box.ReadOnly = true;
            this.syntax_box.Size = new System.Drawing.Size(250, 219);
            this.syntax_box.TabIndex = 35;
            this.syntax_box.Text = "";
            // 
            // practice_box
            // 
            this.practice_box.BackColor = System.Drawing.Color.LemonChiffon;
            this.practice_box.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.practice_box.ForeColor = System.Drawing.Color.OrangeRed;
            this.practice_box.Location = new System.Drawing.Point(235, 269);
            this.practice_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.practice_box.Name = "practice_box";
            this.practice_box.Size = new System.Drawing.Size(480, 320);
            this.practice_box.TabIndex = 34;
            this.practice_box.Text = "";
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.check.ForeColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(12, 595);
            this.check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(908, 50);
            this.check.TabIndex = 33;
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.verifica_Click);
            // 
            // explain_box
            // 
            this.explain_box.BackColor = System.Drawing.Color.PaleGreen;
            this.explain_box.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.explain_box.ForeColor = System.Drawing.Color.MidnightBlue;
            this.explain_box.Location = new System.Drawing.Point(268, 46);
            this.explain_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.explain_box.Name = "explain_box";
            this.explain_box.ReadOnly = true;
            this.explain_box.Size = new System.Drawing.Size(652, 219);
            this.explain_box.TabIndex = 32;
            this.explain_box.Text = "";
            this.explain_box.Visible = false;
            // 
            // LearningDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 653);
            this.Controls.Add(this.detalii);
            this.Controls.Add(this.general);
            this.Controls.Add(this.syntax_box);
            this.Controls.Add(this.practice_box);
            this.Controls.Add(this.check);
            this.Controls.Add(this.explain_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LearningDoWhile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearningDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button detalii;
        private System.Windows.Forms.Label general;
        private System.Windows.Forms.RichTextBox syntax_box;
        private System.Windows.Forms.RichTextBox practice_box;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.RichTextBox explain_box;
    }
}