namespace Pseudocode_Master
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.Welcome = new System.Windows.Forms.Label();
            this.EnterTranslator = new System.Windows.Forms.Button();
            this.EnterLearning = new System.Windows.Forms.Button();
            this.EnterBuilder = new System.Windows.Forms.Button();
            this.SelectOption = new System.Windows.Forms.Label();
            this.EnterCodeChecker = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.VSver = new System.Windows.Forms.Label();
            this.EnterHelp = new System.Windows.Forms.Button();
            this.LanguageChooser = new System.Windows.Forms.ComboBox();
            this.LearningPicture = new System.Windows.Forms.PictureBox();
            this.CodeCheckerPicture = new System.Windows.Forms.PictureBox();
            this.TranslatorPicture = new System.Windows.Forms.PictureBox();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.ExclamationBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LearningPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeCheckerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslatorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExclamationBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Welcome.ForeColor = System.Drawing.Color.Black;
            this.Welcome.Location = new System.Drawing.Point(17, 16);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(0, 33);
            this.Welcome.TabIndex = 0;
            // 
            // EnterTranslator
            // 
            this.EnterTranslator.AutoSize = true;
            this.EnterTranslator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterTranslator.BackColor = System.Drawing.Color.Transparent;
            this.EnterTranslator.FlatAppearance.BorderSize = 0;
            this.EnterTranslator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterTranslator.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTranslator.ForeColor = System.Drawing.Color.Black;
            this.EnterTranslator.Location = new System.Drawing.Point(93, 320);
            this.EnterTranslator.Margin = new System.Windows.Forms.Padding(4);
            this.EnterTranslator.Name = "EnterTranslator";
            this.EnterTranslator.Size = new System.Drawing.Size(6, 6);
            this.EnterTranslator.TabIndex = 1;
            this.EnterTranslator.UseVisualStyleBackColor = false;
            this.EnterTranslator.Click += new System.EventHandler(this.EnterTranslator_Click);
            // 
            // EnterLearning
            // 
            this.EnterLearning.AutoSize = true;
            this.EnterLearning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterLearning.BackColor = System.Drawing.Color.Transparent;
            this.EnterLearning.FlatAppearance.BorderSize = 0;
            this.EnterLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterLearning.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnterLearning.ForeColor = System.Drawing.Color.Black;
            this.EnterLearning.Location = new System.Drawing.Point(93, 112);
            this.EnterLearning.Margin = new System.Windows.Forms.Padding(4);
            this.EnterLearning.Name = "EnterLearning";
            this.EnterLearning.Size = new System.Drawing.Size(6, 6);
            this.EnterLearning.TabIndex = 2;
            this.EnterLearning.UseVisualStyleBackColor = false;
            this.EnterLearning.Click += new System.EventHandler(this.EnterLearning_Click);
            // 
            // EnterBuilder
            // 
            this.EnterBuilder.AutoSize = true;
            this.EnterBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterBuilder.BackColor = System.Drawing.Color.White;
            this.EnterBuilder.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Underline);
            this.EnterBuilder.Location = new System.Drawing.Point(17, 492);
            this.EnterBuilder.Margin = new System.Windows.Forms.Padding(4);
            this.EnterBuilder.Name = "EnterBuilder";
            this.EnterBuilder.Size = new System.Drawing.Size(6, 6);
            this.EnterBuilder.TabIndex = 3;
            this.EnterBuilder.UseVisualStyleBackColor = false;
            this.EnterBuilder.Visible = false;
            this.EnterBuilder.Click += new System.EventHandler(this.EnterBuilder_Click);
            // 
            // SelectOption
            // 
            this.SelectOption.AutoSize = true;
            this.SelectOption.BackColor = System.Drawing.Color.Transparent;
            this.SelectOption.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectOption.ForeColor = System.Drawing.Color.Black;
            this.SelectOption.Location = new System.Drawing.Point(17, 64);
            this.SelectOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectOption.Name = "SelectOption";
            this.SelectOption.Size = new System.Drawing.Size(0, 33);
            this.SelectOption.TabIndex = 4;
            // 
            // EnterCodeChecker
            // 
            this.EnterCodeChecker.AutoSize = true;
            this.EnterCodeChecker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterCodeChecker.BackColor = System.Drawing.Color.Transparent;
            this.EnterCodeChecker.FlatAppearance.BorderSize = 0;
            this.EnterCodeChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterCodeChecker.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCodeChecker.ForeColor = System.Drawing.Color.Black;
            this.EnterCodeChecker.Location = new System.Drawing.Point(93, 208);
            this.EnterCodeChecker.Margin = new System.Windows.Forms.Padding(4);
            this.EnterCodeChecker.Name = "EnterCodeChecker";
            this.EnterCodeChecker.Size = new System.Drawing.Size(6, 6);
            this.EnterCodeChecker.TabIndex = 5;
            this.EnterCodeChecker.UseVisualStyleBackColor = false;
            this.EnterCodeChecker.Click += new System.EventHandler(this.EnterCodeChecker_Click);
            // 
            // Copyright
            // 
            this.Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.Transparent;
            this.Copyright.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Copyright.ForeColor = System.Drawing.Color.Black;
            this.Copyright.Location = new System.Drawing.Point(386, 522);
            this.Copyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(0, 23);
            this.Copyright.TabIndex = 6;
            // 
            // VSver
            // 
            this.VSver.AutoSize = true;
            this.VSver.BackColor = System.Drawing.Color.Transparent;
            this.VSver.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VSver.ForeColor = System.Drawing.Color.Black;
            this.VSver.Location = new System.Drawing.Point(286, 484);
            this.VSver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VSver.Name = "VSver";
            this.VSver.Size = new System.Drawing.Size(0, 27);
            this.VSver.TabIndex = 7;
            // 
            // EnterHelp
            // 
            this.EnterHelp.AutoSize = true;
            this.EnterHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EnterHelp.BackColor = System.Drawing.Color.Transparent;
            this.EnterHelp.FlatAppearance.BorderSize = 0;
            this.EnterHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterHelp.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterHelp.Location = new System.Drawing.Point(93, 400);
            this.EnterHelp.Margin = new System.Windows.Forms.Padding(4);
            this.EnterHelp.Name = "EnterHelp";
            this.EnterHelp.Size = new System.Drawing.Size(6, 6);
            this.EnterHelp.TabIndex = 8;
            this.EnterHelp.UseVisualStyleBackColor = false;
            this.EnterHelp.Click += new System.EventHandler(this.EnterHelp_Click);
            // 
            // LanguageChooser
            // 
            this.LanguageChooser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LanguageChooser.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageChooser.FormattingEnabled = true;
            this.LanguageChooser.Items.AddRange(new object[] {
            "English",
            "Romanian",
            "Other"});
            this.LanguageChooser.Location = new System.Drawing.Point(16, 513);
            this.LanguageChooser.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageChooser.Name = "LanguageChooser";
            this.LanguageChooser.Size = new System.Drawing.Size(160, 39);
            this.LanguageChooser.TabIndex = 9;
            this.LanguageChooser.SelectedValueChanged += new System.EventHandler(this.LanguageChooser_SelectedValueChanged);
            // 
            // LearningPicture
            // 
            this.LearningPicture.BackColor = System.Drawing.Color.Transparent;
            this.LearningPicture.BackgroundImage = global::Pseudocode_Master.Properties.Resources.Learning_Envorinment;
            this.LearningPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearningPicture.Location = new System.Drawing.Point(12, 112);
            this.LearningPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LearningPicture.Name = "LearningPicture";
            this.LearningPicture.Size = new System.Drawing.Size(75, 75);
            this.LearningPicture.TabIndex = 10;
            this.LearningPicture.TabStop = false;
            // 
            // CodeCheckerPicture
            // 
            this.CodeCheckerPicture.BackgroundImage = global::Pseudocode_Master.Properties.Resources.Check;
            this.CodeCheckerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CodeCheckerPicture.Location = new System.Drawing.Point(12, 208);
            this.CodeCheckerPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodeCheckerPicture.Name = "CodeCheckerPicture";
            this.CodeCheckerPicture.Size = new System.Drawing.Size(75, 75);
            this.CodeCheckerPicture.TabIndex = 11;
            this.CodeCheckerPicture.TabStop = false;
            // 
            // TranslatorPicture
            // 
            this.TranslatorPicture.BackgroundImage = global::Pseudocode_Master.Properties.Resources.Refresh;
            this.TranslatorPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TranslatorPicture.Location = new System.Drawing.Point(12, 304);
            this.TranslatorPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TranslatorPicture.Name = "TranslatorPicture";
            this.TranslatorPicture.Size = new System.Drawing.Size(75, 75);
            this.TranslatorPicture.TabIndex = 12;
            this.TranslatorPicture.TabStop = false;
            // 
            // HelpBox
            // 
            this.HelpBox.BackgroundImage = global::Pseudocode_Master.Properties.Resources.HALP;
            this.HelpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpBox.Location = new System.Drawing.Point(12, 400);
            this.HelpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(75, 75);
            this.HelpBox.TabIndex = 13;
            this.HelpBox.TabStop = false;
            // 
            // ExclamationBox
            // 
            this.ExclamationBox.BackColor = System.Drawing.Color.Transparent;
            this.ExclamationBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExclamationBox.Image = global::Pseudocode_Master.Properties.Resources.Blinking_exclamation_mark;
            this.ExclamationBox.Location = new System.Drawing.Point(603, 16);
            this.ExclamationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExclamationBox.Name = "ExclamationBox";
            this.ExclamationBox.Size = new System.Drawing.Size(21, 75);
            this.ExclamationBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExclamationBox.TabIndex = 14;
            this.ExclamationBox.TabStop = false;
            this.ExclamationBox.Click += new System.EventHandler(this.ExclamationBox_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pseudocode_Master.Properties.Resources.Tree_Alone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.ExclamationBox);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.TranslatorPicture);
            this.Controls.Add(this.CodeCheckerPicture);
            this.Controls.Add(this.LearningPicture);
            this.Controls.Add(this.LanguageChooser);
            this.Controls.Add(this.EnterHelp);
            this.Controls.Add(this.VSver);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.EnterCodeChecker);
            this.Controls.Add(this.SelectOption);
            this.Controls.Add(this.EnterBuilder);
            this.Controls.Add(this.EnterLearning);
            this.Controls.Add(this.EnterTranslator);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pseudocode Learning Companion 2015";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Window_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LearningPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeCheckerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslatorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExclamationBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button EnterTranslator;
        private System.Windows.Forms.Button EnterLearning;
        private System.Windows.Forms.Button EnterBuilder;
        private System.Windows.Forms.Label SelectOption;
        private System.Windows.Forms.Button EnterCodeChecker;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label VSver;
        private System.Windows.Forms.Button EnterHelp;
        private System.Windows.Forms.PictureBox LearningPicture;
        private System.Windows.Forms.PictureBox CodeCheckerPicture;
        private System.Windows.Forms.PictureBox TranslatorPicture;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.PictureBox ExclamationBox;
        private System.Windows.Forms.ComboBox LanguageChooser;
    }
}

