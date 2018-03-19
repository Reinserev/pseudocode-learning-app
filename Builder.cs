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
    public partial class Builder : Form
    {
        public Builder()
        {
            InitializeComponent();
            this.Text = Main_Window.construieste;
            citeste.Text = Main_Window.citire;
            scrie.Text = Main_Window.scriere;
            declara.Text = Main_Window.declarare;
            atribuie.Text = Main_Window.atribuie;
            daca.Text = Main_Window.daca;
            pentru.Text = Main_Window.pentru;
            cat_timp.Text = Main_Window.cat_timp;
            repeta_pana_cand.Text = Main_Window.repeta + '/' + Main_Window.pana_cand;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
