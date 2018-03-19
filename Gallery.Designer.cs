namespace Pseudocode_Master
{
    partial class Gallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gallery));
            this.poza = new System.Windows.Forms.PictureBox();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).BeginInit();
            this.SuspendLayout();
            // 
            // poza
            // 
            this.poza.Image = global::Pseudocode_Master.Properties.Resources.MI;
            this.poza.Location = new System.Drawing.Point(12, 12);
            this.poza.Name = "poza";
            this.poza.Size = new System.Drawing.Size(1155, 610);
            this.poza.TabIndex = 0;
            this.poza.TabStop = false;
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(12, 628);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(550, 50);
            this.previous.TabIndex = 1;
            this.previous.Text = "previous";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(617, 628);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(550, 50);
            this.next.TabIndex = 2;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.poza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gallery";
            this.Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.poza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox poza;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
    }
}