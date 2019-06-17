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
                
            }
            else
            {
                MessageBox.Show("Il faut choisir un élément ", "Erreur");

            }
            
               
                while (listBox1.SelectedItems.Count != 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }




            }
        private void Button2_Click(object sender, EventArgs e)
            {

            

            if (listBox2.SelectedIndex >-1)
            {
                
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
               
            }
            else
            {
               
                MessageBox.Show("Il faut choisir un élément ", "Erreur");
                
            }
        }
        }
    }

