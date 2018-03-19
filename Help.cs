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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.Text = Main_Window.help;
            HelpBox.Text = Main_Window.help_learningenvironment +"\n\n" + Main_Window.help_codechecker + "\n\n" + Main_Window.help_translator + "\n\n" + Main_Window.help_help;
            open_gallery.Text = Main_Window.open_gallery;
            // builder goes here
        }

        private void open_gallery_Click(object sender, EventArgs e)
        {
            Gallery f = new Gallery();
            f.Show();
        }
    }
}
