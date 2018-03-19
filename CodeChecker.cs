using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pseudocode_Master;

namespace Pseudocode_Master
{
    public partial class CodeChecker : Form
    {
        bool SEMAFOR = false;

        public CodeChecker()
        {
            InitializeComponent();
            this.Text = Main_Window.verifica;
            Action.Text = Main_Window.check_now;
            nag.Text = Main_Window.alt_avertisment;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text Files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
                Verificator.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.Filter = "Text Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Verificator.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void Action_Click(object sender, EventArgs e)
        {
            Action.Enabled = false;

            SEMAFOR = false;
            string problem = "";

            if (Verificator.Text != "")
            {
                string code, translated;
                code = Verificator.Text;
                string[] split = code.Split('\n');
                int i = 0;
                Verificator.Text = "";
                while (i < split.Length && SEMAFOR == false)
                {
                    translated = split[i];
                    if (translated.Length >= 1)
                    {
                        translated = Verificare_Sintaxa.conversie(translated, ref SEMAFOR);
                        if (SEMAFOR == true && problem == "")
                            problem = translated;
                        Verificator.Text = Verificator.Text + translated;
                        if (translated != "")
                            Verificator.Text = Verificator.Text + '\n';
                    }
                    i++;
                }
            }

            if (SEMAFOR == true)
                MessageBox.Show(Main_Window.prima_linie+'\n'+problem);
            else
            {
                if (Verificare_Sintaxa.verifica_sintaxa(Verificator.Text)==true)
                    MessageBox.Show(Main_Window.corect);
                else
                    MessageBox.Show(Main_Window.gresit);
            }

            if(SEMAFOR == false && Verificare_Sintaxa.verifica_sintaxa(Verificator.Text)==true)
            {
                string code, translated;
                code = Verificator.Text;
                string[] split = code.Split('\n');
                int i = 0, ct = 0, j;
                Verificator.Text = "";
                while (i < split.Length)
                {
                    translated = split[i];

                    if (translated.Contains(Main_Window.sfdaca) || translated.Contains(Main_Window.sfpentru) || translated.Contains(Main_Window.sfcattimp) || translated.Contains(Main_Window.pana_cand))
                    {
                        ct--;
                        // adaug ident-ul
                        for (j = 1; j <= ct; j++)
                            translated = "   " + translated;

                        // afisez
                        Verificator.Text = Verificator.Text + translated;
                        if (translated != "")
                            Verificator.Text = Verificator.Text + '\n';
                        i++;
                    }
                    else
                    {
                        if (translated.Contains(Main_Window.altfel) == true)
                        {
                            ct--;
                            for (j = 1; j <= ct; j++)
                                translated = "   " + translated;

                            // afisez
                            Verificator.Text = Verificator.Text + translated;
                            if (translated != "")
                                Verificator.Text = Verificator.Text + '\n';
                            i++;
                            ct++;
                        }
                        else
                        {
                            // adaug ident-ul
                            for (j = 1; j <= ct; j++)
                                translated = "   " + translated;

                            // afisez
                            Verificator.Text = Verificator.Text + translated;
                            if (translated != "")
                                Verificator.Text = Verificator.Text + '\n';
                            i++;
                            if (translated.Contains(Main_Window.daca) || translated.Contains(Main_Window.pentru) || translated.Contains(Main_Window.cat_timp) || translated.Contains(Main_Window.repeta))
                                ct++;
                        }
                    }
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verificator.Text = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Verificator.Text); ;
                Verificator.Text = "";
            }
            catch
            {
                ;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Verificator.Text);
            }
            catch
            {
                ;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Verificator.Text = Verificator.Text + Clipboard.GetText();
            }
            catch
            {
                ;
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
