using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pseudocode_Master
{
    public partial class LearningRead : Form
    {
        public LearningRead()
        {
            InitializeComponent();
            this.Text = (Main_Window.invata.Split(' '))[0] + ' ' + Main_Window.citire;
            check.Text = Main_Window.check_now;

            general.Text = Main_Window.general;
            practice_box.Text = Main_Window.scriere;
            detalii.Text = Main_Window.arata;
            syntax_box.Text = Main_Window.CITESC[0];
            int i;
            for (i = 1; i <= 2; i++)
                explain_box.Text = explain_box.Text + Main_Window.CITESC[i] + '\n';
            explain_box.Text = explain_box.Text + Main_Window.CITESC[i];
            practice_box.Text = Main_Window.citire;
        }

        private void verifica_Click(object sender, EventArgs e)
        {
            if (practice_box.Text.Contains(Main_Window.citire) == false)
                MessageBox.Show(Main_Window.gresit);
            else
            {
                string code, translated;
                code = practice_box.Text;
                string[] split = code.Split('\n');
                int i = 0;
                bool sem = false;
                while (i < split.Length && sem == false)
                {
                    translated = split[i];
                    translated = Verificare_Sintaxa.conversie(translated, ref sem);
                    i++;
                }
                if (sem == false)
                    MessageBox.Show(Main_Window.corect);
                else
                    MessageBox.Show(Main_Window.gresit);
            }
        }

        private void detalii_Click(object sender, EventArgs e)
        {
            if (explain_box.Visible == false)
            {
                explain_box.Visible = true;
                detalii.Text = Main_Window.ascunde;
            }
            else
            {
                explain_box.Visible = false;
                detalii.Text = Main_Window.arata;
            }
        }
    }
}
