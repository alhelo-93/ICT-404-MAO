namespace WindowsFormsApp1
{
    partial class fentre
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
            this.cmdblue = new System.Windows.Forms.Button();
            this.cmdred = new System.Windows.Forms.Button();
            this.cmdupleft = new System.Windows.Forms.Button();
            this.cmdright = new System.Windows.Forms.Button();
            this.cmddownleft = new System.Windows.Forms.Button();
            this.cmddownright = new System.Windows.Forms.Button();
            this.cmdststs = new System.Windows.Forms.Button();
            this.cmdquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdblue
            // 
            this.cmdblue.Location = new System.Drawing.Point(297, 143);
            this.cmdblue.Name = "cmdblue";
            this.cmdblue.Size = new System.Drawing.Size(75, 23);
            this.cmdblue.TabIndex = 0;
            this.cmdblue.Text = "Bleu";
            this.cmdblue.UseVisualStyleBackColor = true;
            this.cmdblue.Click += new System.EventHandler(this.cmdblue_Click);
            this.cmdblue.MouseHover += new System.EventHandler(this.cmdblue_MouseHover);
            // 
            // cmdred
            // 
            this.cmdred.Location = new System.Drawing.Point(297, 182);
            this.cmdred.Name = "cmdred";
            this.cmdred.Size = new System.Drawing.Size(75, 23);
            this.cmdred.TabIndex = 1;
            this.cmdred.Text = "Rouge";
            this.cmdred.UseVisualStyleBackColor = true;
            // 
            // cmdupleft
            // 
            this.cmdupleft.Location = new System.Drawing.Point(12, 12);
            this.cmdupleft.Name = "cmdupleft";
            this.cmdupleft.Size = new System.Drawing.Size(75, 23);
            this.cmdupleft.TabIndex = 2;
            this.cmdupleft.Text = "Haut/Gauche";
            this.cmdupleft.UseVisualStyleBackColor = true;
            // 
            // cmdright
            // 
            this.cmdright.Location = new System.Drawing.Point(612, 12);
            this.cmdright.Name = "cmdright";
            this.cmdright.Size = new System.Drawing.Size(75, 23);
            this.cmdright.TabIndex = 3;
            this.cmdright.Text = "Haut/Droite";
            this.cmdright.UseVisualStyleBackColor = true;
            // 
            // cmddownleft
            // 
            this.cmddownleft.Location = new System.Drawing.Point(12, 443);
            this.cmddownleft.Name = "cmddownleft";
            this.cmddownleft.Size = new System.Drawing.Size(75, 23);
            this.cmddownleft.TabIndex = 4;
            this.cmddownleft.Text = "Bas/Gauche";
            this.cmddownleft.UseVisualStyleBackColor = true;
            // 
            // cmddownright
            // 
            this.cmddownright.Location = new System.Drawing.Point(612, 443);
            this.cmddownright.Name = "cmddownright";
            this.cmddownright.Size = new System.Drawing.Size(75, 23);
            this.cmddownright.TabIndex = 5;
            this.cmddownright.Text = "Bas/Droite";
            this.cmddownright.UseVisualStyleBackColor = true;
            // 
            // cmdststs
            // 
            this.cmdststs.Location = new System.Drawing.Point(297, 241);
            this.cmdststs.Name = "cmdststs";
            this.cmdststs.Size = new System.Drawing.Size(75, 23);
            this.cmdststs.TabIndex = 6;
            this.cmdststs.Text = "Stats";
            this.cmdststs.UseVisualStyleBackColor = true;
            // 
            // cmdquit
            // 
            this.cmdquit.Location = new System.Drawing.Point(297, 288);
            this.cmdquit.Name = "cmdquit";
            this.cmdquit.Size = new System.Drawing.Size(75, 23);
            this.cmdquit.TabIndex = 7;
            this.cmdquit.Text = "Quitter";
            this.cmdquit.UseVisualStyleBackColor = true;
            this.cmdquit.Click += new System.EventHandler(this.cmdquit_Click);
            // 
            // fentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 478);
            this.Controls.Add(this.cmdquit);
            this.Controls.Add(this.cmdststs);
            this.Controls.Add(this.cmddownright);
            this.Controls.Add(this.cmddownleft);
            this.Controls.Add(this.cmdright);
            this.Controls.Add(this.cmdupleft);
            this.Controls.Add(this.cmdred);
            this.Controls.Add(this.cmdblue);
            this.Name = "fentre";
            this.Text = "Fenetre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdblue;
        private System.Windows.Forms.Button cmdred;
        private System.Windows.Forms.Button cmdupleft;
        private System.Windows.Forms.Button cmdright;
        private System.Windows.Forms.Button cmddownleft;
        private System.Windows.Forms.Button cmddownright;
        private System.Windows.Forms.Button cmdststs;
        private System.Windows.Forms.Button cmdquit;
    }
}

