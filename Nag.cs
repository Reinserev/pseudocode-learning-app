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
    public partial class Nag : Form
    {
        public Nag(string mesaj)
        {
            InitializeComponent();
            nag_box.Text = mesaj;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
