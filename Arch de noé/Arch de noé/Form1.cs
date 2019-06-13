using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arch_de_noé
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1){

                MessageBox.Show("il faut choisir un élément ","Erreur");
            }
        }
    }
}
