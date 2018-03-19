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
    public partial class Learning : Form
    {
        public Learning()
        {
            InitializeComponent();
            this.Text = Main_Window.invata;
            Read.Text = Main_Window.citire;
            Write.Text = Main_Window.scriere;
            Attrib.Text = Main_Window.atribuie;
            If.Text = Main_Window.daca;
            While.Text = Main_Window.cat_timp;
            For.Text = Main_Window.pentru;
            Do_while.Text = Main_Window.repeta + " " + Main_Window.pana_cand;
            Declare.Text = Main_Window.declarare;
            instructiune.Text = Main_Window.selecteaza_instructiunea;
        }

        private void Read_Click(object sender, EventArgs e)
        {
            LearningRead f = new LearningRead();
            f.Show();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            LearningWrite f = new LearningWrite();
            f.Show();
        }

        private void Attrib_Click(object sender, EventArgs e)
        {
            LearningAttrib f = new LearningAttrib();
            f.Show();
        }

        private void If_Click(object sender, EventArgs e)
        {
            LearningIf f = new LearningIf();
            f.Show();
        }

        private void For_Click(object sender, EventArgs e)
        {
            LearningFor f = new LearningFor();
            f.Show();
        }

        private void While_Click(object sender, EventArgs e)
        {
            LearningWhile f = new LearningWhile();
            f.Show();
        }

        private void Do_while_Click(object sender, EventArgs e)
        {
            LearningDoWhile f = new LearningDoWhile();
            f.Show();
        }

        private void Declare_Click(object sender, EventArgs e)
        {
            LearningDeclare f = new LearningDeclare();
            f.Show();
        }

        private void Learning_FormClosed(object sender, FormClosedEventArgs e)
        {
            ; // TODO: maximize main window
        }
    }
}
