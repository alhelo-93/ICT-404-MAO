namespace Test_email
{
    partial class checkmail
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
            this.lbl_mail_check = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.checkA = new System.Windows.Forms.CheckBox();
            this.nbafterA = new System.Windows.Forms.TextBox();
            this.nbbeforA = new System.Windows.Forms.TextBox();
            this.checkpoint = new System.Windows.Forms.CheckBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.nameuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_mail_check
            // 
            this.lbl_mail_check.AutoSize = true;
            this.lbl_mail_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail_check.Location = new System.Drawing.Point(12, 38);
            this.lbl_mail_check.Name = "lbl_mail_check";
            this.lbl_mail_check.Size = new System.Drawing.Size(111, 20);
            this.lbl_mail_check.TabIndex = 0;
            this.lbl_mail_check.Text = "Eamil à vérifier";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(436, 35);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(81, 23);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Vérifier";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(142, 38);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(252, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.Txtemail_TextChanged);
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkA.Location = new System.Drawing.Point(53, 133);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(114, 24);
            this.checkA.TabIndex = 3;
            this.checkA.Text = "\"@\" présent";
            this.checkA.UseVisualStyleBackColor = true;
            // 
            // nbafterA
            // 
            this.nbafterA.Location = new System.Drawing.Point(33, 163);
            this.nbafterA.Name = "nbafterA";
            this.nbafterA.ReadOnly = true;
            this.nbafterA.Size = new System.Drawing.Size(24, 20);
            this.nbafterA.TabIndex = 4;
            this.nbafterA.Text = "15";
            // 
            // nbbeforA
            // 
            this.nbbeforA.Location = new System.Drawing.Point(33, 203);
            this.nbbeforA.Name = "nbbeforA";
            this.nbbeforA.Size = new System.Drawing.Size(24, 20);
            this.nbbeforA.TabIndex = 5;
            this.nbbeforA.Text = "9";
            // 
            // checkpoint
            // 
            this.checkpoint.AutoSize = true;
            this.checkpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpoint.Location = new System.Drawing.Point(53, 238);
            this.checkpoint.Name = "checkpoint";
            this.checkpoint.Size = new System.Drawing.Size(174, 24);
            this.checkpoint.TabIndex = 6;
            this.checkpoint.Text = "\".\"présent après \"@\"";
            this.checkpoint.UseVisualStyleBackColor = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(29, 279);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(123, 20);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Nom d\'utlisateur";
            // 
            // nameuser
            // 
            this.nameuser.Location = new System.Drawing.Point(174, 279);
            this.nameuser.Name = "nameuser";
            this.nameuser.Size = new System.Drawing.Size(182, 20);
            this.nameuser.TabIndex = 8;
            // 
            // checkmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.nameuser);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.checkpoint);
            this.Controls.Add(this.nbbeforA);
            this.Controls.Add(this.nbafterA);
            this.Controls.Add(this.checkA);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_mail_check);
            this.Name = "checkmail";
            this.Text = "Vérification d\'Email";
            this.Load += new System.EventHandler(this.Checkmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail_check;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.CheckBox checkA;
        private System.Windows.Forms.TextBox nbbeforA;
        private System.Windows.Forms.CheckBox checkpoint;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox nameuser;
        private System.Windows.Forms.TextBox nbafterA;
    }
}

