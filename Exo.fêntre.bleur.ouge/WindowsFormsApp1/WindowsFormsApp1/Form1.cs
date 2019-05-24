//Marwan Alhelo
//Date : 24.05.19
//Exo fenetre bleu red 


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
        int colorconut = 0;
        int placecount = 0;

        public fentre()
        {
            InitializeComponent();
        }
        // un bouton pour quitter
        private void cmdquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // un bouton de changer le color de fond à bleu
        private void cmdblue_Click(object sender, EventArgs e)
        {
             colorconut++;

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
            cmdblue.BackColor = Color.Brown;
        }
        // un bouton de changer le color de fond à rouge
        private void cmdred_Click(object sender, EventArgs e)
        {
            colorconut++;
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
        // déplacer vers haut gauche 
        private void cmdupleft_Click(object sender, EventArgs e)
        {
            placecount++;
            this.SetBounds(0,0,this.Width,this.Height);
        }
        // déplacer vers haut droite 
        private void cmdright_Click(object sender, EventArgs e)
        {
            placecount++;
            int srcx = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int srcy= Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.SetBounds(srcx, 0, this.Width, this.Height);

        }
        // déplacer vers le bas gauche
        private void cmddownright_Click(object sender, EventArgs e)
        {
            placecount++;
            int srcx = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int srcy = Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.SetBounds(srcx, srcy, this.Width, this.Height);
        }
        // déplacer vers le bas droite
        private void cmddownleft_Click(object sender, EventArgs e)
        {
            placecount++;
            int srcx = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int srcy = Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.SetBounds(0, srcy, this.Width, this.Height);
        }
        // positioner la fentre au milieu de on démmrage la fentre
        private void fentre_Load(object sender, EventArgs e)
        {
            placecount++;
            int srcx = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int srcy = Screen.PrimaryScreen.Bounds.Height - this.Height;
            this.SetBounds(srcx/2, srcy/2, this.Width, this.Height);
        }
        // affiche un message combien on de fois on a déplacer 
        private void cmdststs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(placecount + " déplacement(s)" + " changment(s) de couleur" + colorconut);
        }
    }
}
