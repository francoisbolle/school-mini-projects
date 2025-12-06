namespace MultiF
{
    partial class Principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        /// 

        public Loc inter_loc;
        //Secondaire Form_Intro;

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
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Intro = new System.Windows.Forms.Button();
            this.label_Ville = new System.Windows.Forms.Label();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label_TypLoc = new System.Windows.Forms.Label();
            this.textBox_TypLoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(118, 102);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 0;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // button_Intro
            // 
            this.button_Intro.Location = new System.Drawing.Point(24, 102);
            this.button_Intro.Name = "button_Intro";
            this.button_Intro.Size = new System.Drawing.Size(75, 23);
            this.button_Intro.TabIndex = 1;
            this.button_Intro.Text = "Introduction";
            this.button_Intro.UseVisualStyleBackColor = true;
            this.button_Intro.Click += new System.EventHandler(this.button_Intro_Click);
            // 
            // label_Ville
            // 
            this.label_Ville.AutoSize = true;
            this.label_Ville.Location = new System.Drawing.Point(72, 26);
            this.label_Ville.Name = "label_Ville";
            this.label_Ville.Size = new System.Drawing.Size(26, 13);
            this.label_Ville.TabIndex = 2;
            this.label_Ville.Text = "Ville";
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(104, 23);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.ReadOnly = true;
            this.textBox_Ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ville.TabIndex = 3;
            // 
            // label_TypLoc
            // 
            this.label_TypLoc.AutoSize = true;
            this.label_TypLoc.Location = new System.Drawing.Point(12, 56);
            this.label_TypLoc.Name = "label_TypLoc";
            this.label_TypLoc.Size = new System.Drawing.Size(86, 13);
            this.label_TypLoc.TabIndex = 4;
            this.label_TypLoc.Text = "Type de location";
            // 
            // textBox_TypLoc
            // 
            this.textBox_TypLoc.Location = new System.Drawing.Point(104, 53);
            this.textBox_TypLoc.Name = "textBox_TypLoc";
            this.textBox_TypLoc.ReadOnly = true;
            this.textBox_TypLoc.Size = new System.Drawing.Size(100, 20);
            this.textBox_TypLoc.TabIndex = 5;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 155);
            this.Controls.Add(this.textBox_TypLoc);
            this.Controls.Add(this.label_TypLoc);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.label_Ville);
            this.Controls.Add(this.button_Intro);
            this.Controls.Add(this.button_Quit);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Intro;
        private System.Windows.Forms.Label label_Ville;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label_TypLoc;
        private System.Windows.Forms.TextBox textBox_TypLoc;
    }
}

