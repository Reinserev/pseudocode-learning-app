namespace Pseudocode_Master
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.HelpBox = new System.Windows.Forms.RichTextBox();
            this.open_gallery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelpBox
            // 
            this.HelpBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpBox.Location = new System.Drawing.Point(17, 16);
            this.HelpBox.Margin = new System.Windows.Forms.Padding(4);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.ReadOnly = true;
            this.HelpBox.Size = new System.Drawing.Size(744, 625);
            this.HelpBox.TabIndex = 0;
            this.HelpBox.Text = "";
            this.HelpBox.UseWaitCursor = true;
            // 
            // open_gallery
            // 
            this.open_gallery.Location = new System.Drawing.Point(17, 648);
            this.open_gallery.Name = "open_gallery";
            this.open_gallery.Size = new System.Drawing.Size(744, 30);
            this.open_gallery.TabIndex = 1;
            this.open_gallery.Text = "Deschide galerie";
            this.open_gallery.UseVisualStyleBackColor = true;
            this.open_gallery.Click += new System.EventHandler(this.open_gallery_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pseudocode_Master.Properties.Resources.help;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 690);
            this.Controls.Add(this.open_gallery);
            this.Controls.Add(this.HelpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox HelpBox;
        private System.Windows.Forms.Button open_gallery;
    }
}