using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// marwan Alhelo
//14.06.19
// Traban
namespace Traban2000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            float i;

            
            if (!float.TryParse(textBox1.Text, out i))
            {

                MessageBox.Show("Entrez un nombre svp", "Erreur");
                textBox1.Focus();
                return;

            }
            if (i < 10000) MessageBox.Show("Entrez un nombre plus grand que 10000", "Erreur");
            if (radioButton1.Checked == true) label3.Text = textBox1.Text;

            
            if (radioButton2.Checked == true) {
                i = i + 2210;
                label3.Text = i.ToString();

               
            }
            
            
            if (checkBox1.Checked == true) {
                i = i+(i * (float)6.8 / 100);
                label3.Text = i.ToString();
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text="12300";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            label3.Text = " ";

        }

        
    }
}
