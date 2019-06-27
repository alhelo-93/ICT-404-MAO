using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// marwan alhelo
// test formative
// 22.06.2019
namespace formative
{
    public partial class frmCourses : Form
    {
        
        public frmCourses()
        {
            InitializeComponent();
        }

       
        // Message d'erreur si il y a un problème solen les consigne
        private void CmdAjouter_Click(object sender, EventArgs e)
        {
            int quntity;
            if (CboArticle.SelectedIndex ==-1 )
            {

                MessageBox.Show("Sélectionnez un article", "Erreur");
            }
            else
            {
                if (txtQuantite.Text == " " || txtQuantite.Text == "0" || !int.TryParse(txtQuantite.Text, out quntity)  )
                {
                    MessageBox.Show("introduisez une quantité", "Erreur");
                }
                else  
                {
                    
                    lstCoures.Items.Add(CboArticle.SelectedItem + " : "+ txtQuantite.Text);
                    CboArticle.Items.Remove(CboArticle.SelectedItem);
                    txtQuantite.ResetText();
                    

                }
            } 
        }

        private void CmdSupprimer_Click(object sender, EventArgs e)
        {

            // j'ai la pine à faire ici 
            if (lstCoures.SelectedItem != null)
            {
                // sur tout enlever la quntité et les " :"
                //listCoures.SelectedItem = listCoures.SelectedItem.ToString().Substring(0,text);
                string s = lstCoures.SelectedItem.ToString();

                int pos = s.IndexOf(":");
                string res = s.Substring(0,pos);

                CboArticle.Items.Add(res);
                
                lstCoures.Items.Remove(lstCoures.SelectedItem);

            }
            else {
                MessageBox.Show("Sélectionnez un article à supprimer", "Erreur");
            }
            
        }

        private void Cmdimprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore disponible","");
        }

        //Déplacer  en haut 

        private void Cmd_haut_Click(object sender, EventArgs e)
        {



            int i = lstCoures.SelectedIndex - 1;
            object  liste = lstCoures.SelectedItem;

            if (i < 0)
                return;
                lstCoures.Items.Remove(liste);
                lstCoures.Items.Insert(i, liste);
                lstCoures.SetSelected(i,true);
            
        }
        //Déplacer  en bas 
        private void Cmd_bas_Click(object sender, EventArgs e)
        {

            int i = lstCoures.SelectedIndex + 1;
            object liste = lstCoures.SelectedItem;

            if (i >= lstCoures.Items.Count)
                return;
            lstCoures.Items.Remove(liste);
            lstCoures.Items.Insert(i, liste);
            lstCoures.SetSelected(i, true);
           
        }
    }

        
    }

