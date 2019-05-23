using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fentre : Form
    {
        public fentre()
        {
            InitializeComponent();
        }

        private void cmdquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdblue_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

        private void cmdblue_MouseHover(object sender, EventArgs e)
        {
            cmdblue.BackColor = Color.Red;
        }
    }
}
