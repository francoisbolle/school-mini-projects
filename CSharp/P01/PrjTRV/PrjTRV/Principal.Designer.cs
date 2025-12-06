namespace PrjTRV
{
    partial class Principal
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
            this.label_Nom = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.button_Val = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.groupBox_Intro = new System.Windows.Forms.GroupBox();
            this.dataGridView_Nom = new System.Windows.Forms.DataGridView();
            this.Column_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nom)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(25, 31);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 0;
            this.label_Nom.Text = "Nom";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(66, 28);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 5;
            this.textBox_Nom.TextChanged += new System.EventHandler(this.textBox_Nom_TextChanged);
            // 
            // button_Val
            // 
            this.button_Val.Enabled = false;
            this.button_Val.Location = new System.Drawing.Point(137, 77);
            this.button_Val.Name = "button_Val";
            this.button_Val.Size = new System.Drawing.Size(75, 23);
            this.button_Val.TabIndex = 10;
            this.button_Val.Text = "Valider";
            this.button_Val.UseVisualStyleBackColor = false;
            this.button_Val.Click += new System.EventHandler(this.button_Val_Click);
            this.button_Val.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Val.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(236, 22);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 20;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = false;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            this.button_Quit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Quit.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_Annuler
            // 
            this.button_Annuler.Enabled = false;
            this.button_Annuler.Location = new System.Drawing.Point(6, 77);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.button_Annuler.TabIndex = 15;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = false;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            this.button_Annuler.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Annuler.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // groupBox_Intro
            // 
            this.groupBox_Intro.Controls.Add(this.button_Val);
            this.groupBox_Intro.Controls.Add(this.textBox_Nom);
            this.groupBox_Intro.Controls.Add(this.button_Annuler);
            this.groupBox_Intro.Controls.Add(this.label_Nom);
            this.groupBox_Intro.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Intro.Name = "groupBox_Intro";
            this.groupBox_Intro.Size = new System.Drawing.Size(218, 117);
            this.groupBox_Intro.TabIndex = 1;
            this.groupBox_Intro.TabStop = false;
            this.groupBox_Intro.Text = "Introduction";
            // 
            // dataGridView_Nom
            // 
            this.dataGridView_Nom.AllowUserToAddRows = false;
            this.dataGridView_Nom.AllowUserToDeleteRows = false;
            this.dataGridView_Nom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Nom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nom});
            this.dataGridView_Nom.Location = new System.Drawing.Point(12, 149);
            this.dataGridView_Nom.Name = "dataGridView_Nom";
            this.dataGridView_Nom.ReadOnly = true;
            this.dataGridView_Nom.Size = new System.Drawing.Size(218, 150);
            this.dataGridView_Nom.TabIndex = 21;
            // 
            // Column_Nom
            // 
            this.Column_Nom.HeaderText = "Nom";
            this.Column_Nom.Name = "Column_Nom";
            this.Column_Nom.ReadOnly = true;
            this.Column_Nom.Width = 175;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 321);
            this.Controls.Add(this.dataGridView_Nom);
            this.Controls.Add(this.groupBox_Intro);
            this.Controls.Add(this.button_Quit);
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox_Intro.ResumeLayout(false);
            this.groupBox_Intro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Button button_Val;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.GroupBox groupBox_Intro;
        private System.Windows.Forms.DataGridView dataGridView_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nom;
    }
}

