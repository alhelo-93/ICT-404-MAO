using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deductions_fiscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Resulta imposable invisible
            Result.Visible = false;
            //case à coucher découcher
            textBox3.Enabled = false;
            //case à coucher découcher
            textBox4.Enabled = false;
            //case à coucher découcher
            textBox5.Enabled = false;
            textBox3.Text = "900";
            textBox4.Text = "650";
            textBox5.Text = "4";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            float i;
            if (!float.TryParse(textBox3.Text, out i))
            {

                MessageBox.Show("Entrez une nombre svp");
                textBox3.Focus();
                return;

            }
            else
            {


            }
            if (checkBox1.Checked == true)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            float i;
            if (!float.TryParse(textBox4.Text, out i))
            {
                MessageBox.Show("Entrez une nombre svp");
                textBox4.Focus();
                return;

            }
            else
            {

            }

            if (checkBox2.Checked == true)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            float i;
            if (!float.TryParse(textBox5.Text, out i))
            {
                MessageBox.Show("Entrez une nombre svp");
                textBox4.Focus();
                return;

            }
            else
            {

            }

            if (checkBox3.Checked == true)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }
        }



        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dés on clique sue bouton calcul la resultat imposable sura visible
            Result.Visible = true;
            float Revnu;
            float Coefficient;
            float Djeune;

            float Dtransport;
            float rabais;
            if (!float.TryParse(textBox1.Text, out Revnu))
            {

                MessageBox.Show("Entrez une nombre svp");
                textBox1.Focus();
                return;

            }
            //dés on clique sue bouton calcul la resultat imposable sura visible
            if (!float.TryParse(textBox2.Text, out Coefficient))
            {
                MessageBox.Show("Entrez une nombre svp");
                textBox2.Focus();
                return;

            }
            //calcule sans les frais fix 
            float calcul = Revnu / Coefficient;


            //si les case cocher sont validé on fait calculer 



            // lire la valeur dans la case de Djeune
            if (!float.TryParse(textBox3.Text, out Djeune))
            {

                MessageBox.Show("Entrez une nombre svp");
                textBox1.Focus();
                return;

            }
            // calcule avec le montant fix Djeune
            if (checkBox1.Checked == true)
            {

                calcul = calcul - Djeune;

            }


            // lire la valeur dans la case de Djeune
            if (!float.TryParse(textBox4.Text, out Dtransport))
            {

                MessageBox.Show("Entrez une nombre svp");
                textBox2.Focus();
                return;

            }
            // calcule avec le montant fix Dtransport
            if (checkBox2.Checked == true)
            {

                calcul = calcul - Dtransport;


            }

            // lire la valeur dans la case de rabais
            if (!float.TryParse(textBox5.Text, out rabais))
            {

                MessageBox.Show("Entrez une nombre svp");
                textBox3.Focus();
                return;

            }
            // calcule avec le montant fix rabis
            if (checkBox3.Checked == true)
            {

                calcul = calcul - (calcul / 100 * rabais);


            }


            Result.Text = "Revenu imposable : " + calcul;


            //test for no things 
        }


    }
}

