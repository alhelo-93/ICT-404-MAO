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
            {


            }

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Sorted = true;
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                button2.Enabled = true;
                if (listBox1.Items.Count == 0)
                {

                    button1.Enabled = false;

                }
            }
            else
            {
                MessageBox.Show("Il faut choisir un élément ", "Erreur");

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {



            if (listBox2.SelectedIndex > -1)
            {

                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                button1.Enabled = true;
                if (listBox2.Items.Count == 0) {

                    button2.Enabled = false;

                }

            }
            else
            {

                MessageBox.Show("Il faut choisir un élément ", "Erreur");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}

