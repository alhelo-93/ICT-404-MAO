using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_email
{
    public partial class checkmail : Form
    {
        public checkmail()
        {
            InitializeComponent();
        }

        private void Checkmail_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtemail;
           
        }

        private void Txtemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_check_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {

                MessageBox.Show("Veuillez remplir le champ Email afin de procéder à sa vérivcation,SVP", "Champ Email Vide");
                lbl_mail_check.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
