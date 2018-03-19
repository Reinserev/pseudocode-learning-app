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
    public partial class Gallery : Form
    {
        public int number = 1;

        void apply_image (int number)
        {
            if (number == 1)
            {
                if (Main_Window.limba == true)
                    poza.Image = Properties.Resources.MI_E;
                else
                    poza.Image = Properties.Resources.MI;
            }
            if (number == 2)
            {
                if (Main_Window.limba == true)
                    poza.Image = Properties.Resources.VC_E;
                else
                    poza.Image = Properties.Resources.VC;
            }
            if (number == 3)
            {
                if (Main_Window.limba == true)
                    poza.Image = Properties.Resources.TR_E;
                else
                    poza.Image = Properties.Resources.TR;
            }
        }

        public Gallery()
        {
            InitializeComponent();
            previous.Text = Main_Window.previous;
            next.Text = Main_Window.next;
            apply_image(number);
        }

        private void previous_Click(object sender, EventArgs e)
        {
            number--;
            if (number < 1)
                number = 3;
            apply_image(number);
        }

        private void next_Click(object sender, EventArgs e)
        {
            number++;
            if (number > 3)
                number = 1;
            apply_image(number);
        }
    }
}
