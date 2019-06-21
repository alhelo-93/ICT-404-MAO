namespace formative
{
    partial class frmCourses
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.CboArticle = new System.Windows.Forms.ComboBox();
            this.CmdAjouter = new System.Windows.Forms.Button();
            this.listCoures = new System.Windows.Forms.ListBox();
            this.CmdSupprimer = new System.Windows.Forms.Button();
            this.cmdimprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(25, 25);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(25, 20);
            this.txtQuantite.TabIndex = 1;
            this.txtQuantite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CboArticle
            // 
            this.CboArticle.FormattingEnabled = true;
            this.CboArticle.Items.AddRange(new object[] {
            "Pain",
            "Beurre",
            "Lait",
            "Confiture",
            "Formage",
            "Oeufs",
            "Farine",
            "Sucre",
            "Viande"});
            this.CboArticle.Location = new System.Drawing.Point(55, 25);
            this.CboArticle.Name = "CboArticle";
            this.CboArticle.Size = new System.Drawing.Size(120, 21);
            this.CboArticle.TabIndex = 2;
            // 
            // CmdAjouter
            // 
            this.CmdAjouter.Location = new System.Drawing.Point(25, 65);
            this.CmdAjouter.Name = "CmdAjouter";
            this.CmdAjouter.Size = new System.Drawing.Size(150, 23);
            this.CmdAjouter.TabIndex = 3;
            this.CmdAjouter.Text = "Ajouter";
            this.CmdAjouter.UseVisualStyleBackColor = true;
            this.CmdAjouter.Click += new System.EventHandler(this.CmdAjouter_Click);
            // 
            // listCoures
            // 
            this.listCoures.FormattingEnabled = true;
            this.listCoures.Location = new System.Drawing.Point(25, 94);
            this.listCoures.Name = "listCoures";
            this.listCoures.Size = new System.Drawing.Size(150, 212);
            this.listCoures.TabIndex = 4;
            // 
            // CmdSupprimer
            // 
            this.CmdSupprimer.Location = new System.Drawing.Point(25, 312);
            this.CmdSupprimer.Name = "CmdSupprimer";
            this.CmdSupprimer.Size = new System.Drawing.Size(150, 23);
            this.CmdSupprimer.TabIndex = 5;
            this.CmdSupprimer.Text = "Supprimer";
            this.CmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdimprimer
            // 
            this.cmdimprimer.Location = new System.Drawing.Point(25, 341);
            this.cmdimprimer.Name = "cmdimprimer";
            this.cmdimprimer.Size = new System.Drawing.Size(150, 23);
            this.cmdimprimer.TabIndex = 6;
            this.cmdimprimer.Text = "Imprimer";
            this.cmdimprimer.UseVisualStyleBackColor = true;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 376);
            this.Controls.Add(this.cmdimprimer);
            this.Controls.Add(this.CmdSupprimer);
            this.Controls.Add(this.listCoures);
            this.Controls.Add(this.CmdAjouter);
            this.Controls.Add(this.CboArticle);
            this.Controls.Add(this.txtQuantite);
            this.Name = "frmCourses";
            this.Text = "Cours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ComboBox CboArticle;
        private System.Windows.Forms.Button CmdAjouter;
        private System.Windows.Forms.ListBox listCoures;
        private System.Windows.Forms.Button CmdSupprimer;
        private System.Windows.Forms.Button cmdimprimer;
    }
}

