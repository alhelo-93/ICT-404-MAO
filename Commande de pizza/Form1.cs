﻿// marwa alhelo
//27.05.19
// Commande de Pizza

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commande_de_pizza
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // change les nom des boutons cheakbox.radio bouton 
            this.Text = "Pizza";
            groupBox1.Text = "Pâte";
            label1.Text = "Table";
            label2.Text = "Commande";
            button1.Text = "Commander";
            Extra.Text = "Extra-fine";
            textBox2.BackColor = System.Drawing.Color.Yellow;




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float table;
            if (!float.TryParse(textBox1.Text, out table))
            {
                MessageBox.Show("Entrez une nombre svp");
                textBox1.Focus();
                return;

            }
        }
    }
}
