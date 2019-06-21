using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formative
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            float quntity;
            if (CboArticle.SelectedIndex ==-1 )
            {

                MessageBox.Show("Sélectionnez un article", "Erreur");
            }
            else
            {
                if (txtQuantite.Text == "" || !float.TryParse(txtQuantite.Text, out quntity)  )
                {
                    MessageBox.Show("introduisez une quantité", "Erreur");
                }
                else  
                {
                    

                }
            }
            


            }
        }

        
    }
}
