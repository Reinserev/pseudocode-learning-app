namespace Pseudocode_Master
{
    partial class Nag
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
            this.nag_box = new System.Windows.Forms.RichTextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nag_box
            // 
            this.nag_box.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nag_box.Location = new System.Drawing.Point(12, 12);
            this.nag_box.Name = "nag_box";
            this.nag_box.Size = new System.Drawing.Size(565, 300);
            this.nag_box.TabIndex = 0;
            this.nag_box.Text = "";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Confirm.Location = new System.Drawing.Point(12, 318);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(565, 36);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Nag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 368);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.nag_box);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nag";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox nag_box;
        private System.Windows.Forms.Button Confirm;
    }
}