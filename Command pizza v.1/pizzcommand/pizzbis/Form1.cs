using System;
using System.Windows.Forms;

namespace pizzbis
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "pizza";
            lblshow.BackColor = System.Drawing.Color.Yellow;
        }

        private void Cmd_Click(object sender, EventArgs e)
        {
            //affiche message d'erreur si on tape de carctere
            float table;
            string msg = "Pour la ";
            if (!float.TryParse(textBox1.Text, out table))
            {
                MessageBox.Show("Entrez une nombre svp", "Erreur");
                MessageBox.Show("Entrez une nombre svp", "Erreur");
                textBox1.Focus();
                return;

            }
            else
            {
                table = float.Parse(textBox1.Text);
                lblshow.Text = msg + table + ":";
            }
            lblshow.Text = msg + table + " : " + " pate ";

            if (exfbutton.Checked == true)
            {

                lblshow.Text = lblshow.Text + exfbutton.Text;
            }
            else
            {
            }
            if (fbutton.Checked == true)
            {
                lblshow.Text = lblshow.Text + fbutton.Text;
            }
            else
            {

            }
            if (Nbutton.Checked == true)
            {
                lblshow.Text = lblshow.Text + Nbutton.Text;
            }
            else
            {

            }
            if (ebutton.Checked == true)
            {
                lblshow.Text = lblshow.Text + ebutton.Text;
            }
            else
            {
            }

            string msg2 = lblshow.Text = lblshow.Text + " Avec ";
            if (chanchois.Checked == true)
            {
                lblshow.Text = msg2 + chanchois.Text + ",";
            }
            else
            {

            }
            if (chcapres.Checked == true)
            {
                lblshow.Text = lblshow.Text + chcapres.Text + ",";
            }
            else
            {
            }
            if (chjambon.Checked == true)
            {
                lblshow.Text = lblshow.Text + chjambon.Text + ",";
            }
            else
            {
            }
            if (chcrevette.Checked == true)
            {
                lblshow.Text = lblshow.Text + chcrevette.Text + ",";



            }
            else
            {

            }
            string txet = lblshow.Text;
            lblshow.Text = txet.Substring(0, txet.Length - 1);


        }
    }
}

