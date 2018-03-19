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
    public partial class LearningDeclare : Form
    {
        public LearningDeclare()
        {
            InitializeComponent();
            this.Text = (Main_Window.invata.Split(' '))[0] + ' ' + Main_Window.declarare;
            check.Text = Main_Window.check_now;

            general.Text = Main_Window.general;
            detalii.Text = Main_Window.arata;
            syntax_box.Text = Main_Window.DECLAR[0];
            int i;
            for (i = 1; i <= 2; i++)
                explain_box.Text = explain_box.Text + Main_Window.DECLAR[i] + '\n';
            explain_box.Text = explain_box.Text + Main_Window.DECLAR[i];
        }

        private void verifica_Click(object sender, EventArgs e)
        {
            string[] declarari = { Main_Window.natural, Main_Window.intreg, Main_Window.rational, Main_Window.real };

            int i; bool sem = false;
            for (i = 0; i <= 3 && sem==false; i++)
                if (practice_box.Text.Contains(declarari[i]) == true)
                    sem = true;

            if (sem == false || Verificare_Sintaxa.verifica_declarare(practice_box.Text) == false)
                MessageBox.Show(Main_Window.gresit);
            else
                MessageBox.Show(Main_Window.corect);
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
