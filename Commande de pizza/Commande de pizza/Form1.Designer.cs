namespace Commande_de_pizza
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Epaisse = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Fine = new System.Windows.Forms.RadioButton();
            this.Extra = new System.Windows.Forms.RadioButton();
            this.Anchois = new System.Windows.Forms.CheckBox();
            this.Capres = new System.Windows.Forms.CheckBox();
            this.Jambon = new System.Windows.Forms.CheckBox();
            this.Crevettes = new System.Windows.Forms.CheckBox();
            this.lblCommande = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Commande = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Epaisse);
            this.groupBox1.Controls.Add(this.Normal);
            this.groupBox1.Controls.Add(this.Fine);
            this.groupBox1.Controls.Add(this.Extra);
            this.groupBox1.Location = new System.Drawing.Point(38, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pâte";
            // 
            // Epaisse
            // 
            this.Epaisse.AutoSize = true;
            this.Epaisse.Location = new System.Drawing.Point(33, 103);
            this.Epaisse.Name = "Epaisse";
            this.Epaisse.Size = new System.Drawing.Size(62, 17);
            this.Epaisse.TabIndex = 7;
            this.Epaisse.Text = "Epaisse";
            this.Epaisse.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(33, 80);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(58, 17);
            this.Normal.TabIndex = 6;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.Location = new System.Drawing.Point(33, 57);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(45, 17);
            this.Fine.TabIndex = 5;
            this.Fine.Text = "Fine";
            this.Fine.UseVisualStyleBackColor = true;
            // 
            // Extra
            // 
            this.Extra.AutoSize = true;
            this.Extra.Location = new System.Drawing.Point(33, 34);
            this.Extra.Name = "Extra";
            this.Extra.Size = new System.Drawing.Size(69, 17);
            this.Extra.TabIndex = 4;
            this.Extra.Text = "Extra-fine";
            this.Extra.UseVisualStyleBackColor = true;
            // 
            // Anchois
            // 
            this.Anchois.AutoSize = true;
            this.Anchois.Location = new System.Drawing.Point(264, 124);
            this.Anchois.Name = "Anchois";
            this.Anchois.Size = new System.Drawing.Size(64, 17);
            this.Anchois.TabIndex = 3;
            this.Anchois.Text = "Anchois";
            this.Anchois.UseVisualStyleBackColor = true;
            // 
            // Capres
            // 
            this.Capres.AutoSize = true;
            this.Capres.Location = new System.Drawing.Point(264, 148);
            this.Capres.Name = "Capres";
            this.Capres.Size = new System.Drawing.Size(59, 17);
            this.Capres.TabIndex = 4;
            this.Capres.Text = "Câpres";
            this.Capres.UseVisualStyleBackColor = true;
            // 
            // Jambon
            // 
            this.Jambon.AutoSize = true;
            this.Jambon.Location = new System.Drawing.Point(264, 171);
            this.Jambon.Name = "Jambon";
            this.Jambon.Size = new System.Drawing.Size(63, 17);
            this.Jambon.TabIndex = 5;
            this.Jambon.Text = "Jambon";
            this.Jambon.UseVisualStyleBackColor = true;
            // 
            // Crevettes
            // 
            this.Crevettes.AutoSize = true;
            this.Crevettes.Location = new System.Drawing.Point(264, 194);
            this.Crevettes.Name = "Crevettes";
            this.Crevettes.Size = new System.Drawing.Size(71, 17);
            this.Crevettes.TabIndex = 6;
            this.Crevettes.Text = "Crevettes";
            this.Crevettes.UseVisualStyleBackColor = true;
            // 
            // lblCommande
            // 
            this.lblCommande.Location = new System.Drawing.Point(71, 332);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(309, 68);
            this.lblCommande.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Commander";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commande
            // 
            this.Commande.AutoSize = true;
            this.Commande.Location = new System.Drawing.Point(71, 292);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(60, 13);
            this.Commande.TabIndex = 9;
            this.Commande.Text = "Commande";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 428);
            this.Controls.Add(this.Commande);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.Jambon);
            this.Controls.Add(this.Crevettes);
            this.Controls.Add(this.Capres);
            this.Controls.Add(this.Anchois);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Epaisse;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Fine;
        private System.Windows.Forms.RadioButton Extra;
        private System.Windows.Forms.CheckBox Anchois;
        private System.Windows.Forms.CheckBox Capres;
        private System.Windows.Forms.CheckBox Jambon;
        private System.Windows.Forms.CheckBox Crevettes;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Commande;
    }
}

