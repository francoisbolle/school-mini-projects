namespace MultiF
{
    partial class Secondaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 

        //Loc test;
        Loc Loc_Persist;    // mémorise la cible du Principal sur toute la durée de vie du Secondaire
        System.Windows.Forms.TextBox TbVille_Persist, TbTypLoc_Persist;


        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label_Ville = new System.Windows.Forms.Label();
            this.button_Val = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_Appart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(102, 21);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ville.TabIndex = 1;
            // 
            // label_Ville
            // 
            this.label_Ville.AutoSize = true;
            this.label_Ville.Location = new System.Drawing.Point(70, 24);
            this.label_Ville.Name = "label_Ville";
            this.label_Ville.Size = new System.Drawing.Size(26, 13);
            this.label_Ville.TabIndex = 8;
            this.label_Ville.Text = "Ville";
            // 
            // button_Val
            // 
            this.button_Val.Location = new System.Drawing.Point(22, 100);
            this.button_Val.Name = "button_Val";
            this.button_Val.Size = new System.Drawing.Size(75, 23);
            this.button_Val.TabIndex = 20;
            this.button_Val.Text = "Valider";
            this.button_Val.UseVisualStyleBackColor = true;
            this.button_Val.Click += new System.EventHandler(this.button_Val_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(116, 100);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 30;
            this.button_Cancel.Text = "Annuler";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox_Appart
            // 
            this.checkBox_Appart.AutoSize = true;
            this.checkBox_Appart.Location = new System.Drawing.Point(102, 62);
            this.checkBox_Appart.Name = "checkBox_Appart";
            this.checkBox_Appart.Size = new System.Drawing.Size(86, 17);
            this.checkBox_Appart.TabIndex = 10;
            this.checkBox_Appart.Text = "Appartement";
            this.checkBox_Appart.UseVisualStyleBackColor = true;
            // 
            // Secondaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 169);
            this.Controls.Add(this.checkBox_Appart);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.label_Ville);
            this.Controls.Add(this.button_Val);
            this.Controls.Add(this.button_Cancel);
            this.Name = "Secondaire";
            this.Text = "Secondaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label_Ville;
        private System.Windows.Forms.Button button_Val;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox_Appart;
    }
}