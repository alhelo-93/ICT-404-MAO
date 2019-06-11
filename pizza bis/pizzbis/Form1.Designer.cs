namespace pizzbis
{
    partial class Pizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ebutton = new System.Windows.Forms.RadioButton();
            this.Nbutton = new System.Windows.Forms.RadioButton();
            this.fbutton = new System.Windows.Forms.RadioButton();
            this.exfbutton = new System.Windows.Forms.RadioButton();
            this.chanchois = new System.Windows.Forms.CheckBox();
            this.chcapres = new System.Windows.Forms.CheckBox();
            this.chjambon = new System.Windows.Forms.CheckBox();
            this.chcrevette = new System.Windows.Forms.CheckBox();
            this.Cmd = new System.Windows.Forms.Button();
            this.labelcmd = new System.Windows.Forms.Label();
            this.cmdchange = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ebutton);
            this.groupBox1.Controls.Add(this.Nbutton);
            this.groupBox1.Controls.Add(this.fbutton);
            this.groupBox1.Controls.Add(this.exfbutton);
            this.groupBox1.Location = new System.Drawing.Point(37, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pates";
            // 
            // ebutton
            // 
            this.ebutton.AutoSize = true;
            this.ebutton.Location = new System.Drawing.Point(13, 99);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(62, 17);
            this.ebutton.TabIndex = 8;
            this.ebutton.TabStop = true;
            this.ebutton.Text = "Epaisse";
            this.ebutton.UseVisualStyleBackColor = true;
            // 
            // Nbutton
            // 
            this.Nbutton.AutoSize = true;
            this.Nbutton.Location = new System.Drawing.Point(13, 76);
            this.Nbutton.Name = "Nbutton";
            this.Nbutton.Size = new System.Drawing.Size(55, 17);
            this.Nbutton.TabIndex = 7;
            this.Nbutton.TabStop = true;
            this.Nbutton.Text = "Nomal";
            this.Nbutton.UseVisualStyleBackColor = true;
            // 
            // fbutton
            // 
            this.fbutton.AutoSize = true;
            this.fbutton.Location = new System.Drawing.Point(13, 53);
            this.fbutton.Name = "fbutton";
            this.fbutton.Size = new System.Drawing.Size(45, 17);
            this.fbutton.TabIndex = 6;
            this.fbutton.TabStop = true;
            this.fbutton.Text = "Fine";
            this.fbutton.UseVisualStyleBackColor = true;
            // 
            // exfbutton
            // 
            this.exfbutton.AutoSize = true;
            this.exfbutton.Location = new System.Drawing.Point(13, 30);
            this.exfbutton.Name = "exfbutton";
            this.exfbutton.Size = new System.Drawing.Size(69, 17);
            this.exfbutton.TabIndex = 5;
            this.exfbutton.TabStop = true;
            this.exfbutton.Text = "Extra-fine";
            this.exfbutton.UseVisualStyleBackColor = true;
            // 
            // chanchois
            // 
            this.chanchois.AutoSize = true;
            this.chanchois.Location = new System.Drawing.Point(402, 87);
            this.chanchois.Name = "chanchois";
            this.chanchois.Size = new System.Drawing.Size(64, 17);
            this.chanchois.TabIndex = 5;
            this.chanchois.Text = "Anchois";
            this.chanchois.UseVisualStyleBackColor = true;
            // 
            // chcapres
            // 
            this.chcapres.AutoSize = true;
            this.chcapres.Location = new System.Drawing.Point(402, 111);
            this.chcapres.Name = "chcapres";
            this.chcapres.Size = new System.Drawing.Size(59, 17);
            this.chcapres.TabIndex = 6;
            this.chcapres.Text = "Capres";
            this.chcapres.UseVisualStyleBackColor = true;
            // 
            // chjambon
            // 
            this.chjambon.AutoSize = true;
            this.chjambon.Location = new System.Drawing.Point(402, 133);
            this.chjambon.Name = "chjambon";
            this.chjambon.Size = new System.Drawing.Size(63, 17);
            this.chjambon.TabIndex = 7;
            this.chjambon.Text = "Jambon";
            this.chjambon.UseVisualStyleBackColor = true;
            // 
            // chcrevette
            // 
            this.chcrevette.AutoSize = true;
            this.chcrevette.Location = new System.Drawing.Point(402, 156);
            this.chcrevette.Name = "chcrevette";
            this.chcrevette.Size = new System.Drawing.Size(71, 17);
            this.chcrevette.TabIndex = 8;
            this.chcrevette.Text = "Crevettes";
            this.chcrevette.UseVisualStyleBackColor = true;
            // 
            // Cmd
            // 
            this.Cmd.Location = new System.Drawing.Point(229, 229);
            this.Cmd.Name = "Cmd";
            this.Cmd.Size = new System.Drawing.Size(75, 23);
            this.Cmd.TabIndex = 9;
            this.Cmd.Text = "Commander";
            this.Cmd.UseVisualStyleBackColor = true;
            this.Cmd.Click += new System.EventHandler(this.Cmd_Click);
            // 
            // labelcmd
            // 
            this.labelcmd.AutoSize = true;
            this.labelcmd.Location = new System.Drawing.Point(125, 303);
            this.labelcmd.Name = "labelcmd";
            this.labelcmd.Size = new System.Drawing.Size(62, 13);
            this.labelcmd.TabIndex = 1;
            this.labelcmd.Text = "Répertoire :";
            // 
            // cmdchange
            // 
            this.cmdchange.Location = new System.Drawing.Point(30, 298);
            this.cmdchange.Name = "cmdchange";
            this.cmdchange.Size = new System.Drawing.Size(75, 23);
            this.cmdchange.TabIndex = 10;
            this.cmdchange.Text = "Changer";
            this.cmdchange.UseVisualStyleBackColor = true;
            this.cmdchange.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(207, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mozzarella";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bufflonne";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Maigre";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(13, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Nomale";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdchange);
            this.Controls.Add(this.Cmd);
            this.Controls.Add(this.chcrevette);
            this.Controls.Add(this.chjambon);
            this.Controls.Add(this.chcapres);
            this.Controls.Add(this.chanchois);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelcmd);
            this.Controls.Add(this.label1);
            this.Name = "Pizza";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ebutton;
        private System.Windows.Forms.RadioButton Nbutton;
        private System.Windows.Forms.RadioButton fbutton;
        private System.Windows.Forms.RadioButton exfbutton;
        private System.Windows.Forms.CheckBox chanchois;
        private System.Windows.Forms.CheckBox chcapres;
        private System.Windows.Forms.CheckBox chjambon;
        private System.Windows.Forms.CheckBox chcrevette;
        private System.Windows.Forms.Button Cmd;
        private System.Windows.Forms.Label labelcmd;
        private System.Windows.Forms.Button cmdchange;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

