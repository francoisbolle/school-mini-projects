namespace PrjTRV
{
    partial class Form_Avo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        private avo inter_avo;
        private avo[] Tavo;
        private int current_avo;
         
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
            this.button_Quit = new System.Windows.Forms.Button();
            this.dataGridView_RecapRdv = new System.Windows.Forms.DataGridView();
            this.groupBox_Avo = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_DatAvo = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label_DatAvo = new System.Windows.Forms.Label();
            this.label_Nom = new System.Windows.Forms.Label();
            this.button_ValAvo = new System.Windows.Forms.Button();
            this.button_Cancel_Avo = new System.Windows.Forms.Button();
            this.dataGridView_RecapAvo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_IntroRDV = new System.Windows.Forms.Button();
            this.Column_NoDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DatRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Juge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdv)).BeginInit();
            this.groupBox_Avo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapAvo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(9, 166);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 110;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // dataGridView_RecapRdv
            // 
            this.dataGridView_RecapRdv.AllowUserToAddRows = false;
            this.dataGridView_RecapRdv.AllowUserToDeleteRows = false;
            this.dataGridView_RecapRdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecapRdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NoDos,
            this.TypRdv,
            this.Column_DatRdv,
            this.Column_TimRdv,
            this.Ville,
            this.Juge,
            this.Jury});
            this.dataGridView_RecapRdv.Location = new System.Drawing.Point(9, 225);
            this.dataGridView_RecapRdv.Name = "dataGridView_RecapRdv";
            this.dataGridView_RecapRdv.ReadOnly = true;
            this.dataGridView_RecapRdv.Size = new System.Drawing.Size(570, 238);
            this.dataGridView_RecapRdv.TabIndex = 70;
            this.dataGridView_RecapRdv.TabStop = false;
            this.dataGridView_RecapRdv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapRdv_CellEnter);
            // 
            // groupBox_Avo
            // 
            this.groupBox_Avo.Controls.Add(this.dateTimePicker_DatAvo);
            this.groupBox_Avo.Controls.Add(this.textBox_Nom);
            this.groupBox_Avo.Controls.Add(this.label_DatAvo);
            this.groupBox_Avo.Controls.Add(this.label_Nom);
            this.groupBox_Avo.Controls.Add(this.button_ValAvo);
            this.groupBox_Avo.Controls.Add(this.button_Cancel_Avo);
            this.groupBox_Avo.Location = new System.Drawing.Point(9, 12);
            this.groupBox_Avo.Name = "groupBox_Avo";
            this.groupBox_Avo.Size = new System.Drawing.Size(199, 131);
            this.groupBox_Avo.TabIndex = 1;
            this.groupBox_Avo.TabStop = false;
            this.groupBox_Avo.Text = "Introduction des Avocats";
            // 
            // dateTimePicker_DatAvo
            // 
            this.dateTimePicker_DatAvo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DatAvo.Location = new System.Drawing.Point(102, 50);
            this.dateTimePicker_DatAvo.Name = "dateTimePicker_DatAvo";
            this.dateTimePicker_DatAvo.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker_DatAvo.TabIndex = 20;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(49, 23);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(131, 20);
            this.textBox_Nom.TabIndex = 10;
            this.textBox_Nom.TextChanged += new System.EventHandler(this.textBox_Nom_TextChanged);
            // 
            // label_DatAvo
            // 
            this.label_DatAvo.AutoSize = true;
            this.label_DatAvo.Location = new System.Drawing.Point(14, 58);
            this.label_DatAvo.Name = "label_DatAvo";
            this.label_DatAvo.Size = new System.Drawing.Size(69, 13);
            this.label_DatAvo.TabIndex = 1;
            this.label_DatAvo.Text = "Date diplôme";
            // 
            // label_Nom
            // 
            this.label_Nom.AutoSize = true;
            this.label_Nom.Location = new System.Drawing.Point(14, 26);
            this.label_Nom.Name = "label_Nom";
            this.label_Nom.Size = new System.Drawing.Size(29, 13);
            this.label_Nom.TabIndex = 1;
            this.label_Nom.Text = "Nom";
            // 
            // button_ValAvo
            // 
            this.button_ValAvo.Enabled = false;
            this.button_ValAvo.Location = new System.Drawing.Point(105, 89);
            this.button_ValAvo.Name = "button_ValAvo";
            this.button_ValAvo.Size = new System.Drawing.Size(75, 23);
            this.button_ValAvo.TabIndex = 30;
            this.button_ValAvo.Text = "Valider";
            this.button_ValAvo.UseVisualStyleBackColor = true;
            this.button_ValAvo.Click += new System.EventHandler(this.button_ValAvo_Click);
            // 
            // button_Cancel_Avo
            // 
            this.button_Cancel_Avo.Location = new System.Drawing.Point(17, 89);
            this.button_Cancel_Avo.Name = "button_Cancel_Avo";
            this.button_Cancel_Avo.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel_Avo.TabIndex = 40;
            this.button_Cancel_Avo.Text = "Annuler";
            this.button_Cancel_Avo.UseVisualStyleBackColor = true;
            this.button_Cancel_Avo.Click += new System.EventHandler(this.button_Cancel_Avo_Click);
            // 
            // dataGridView_RecapAvo
            // 
            this.dataGridView_RecapAvo.AllowUserToAddRows = false;
            this.dataGridView_RecapAvo.AllowUserToDeleteRows = false;
            this.dataGridView_RecapAvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecapAvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_RecapAvo.Location = new System.Drawing.Point(232, 18);
            this.dataGridView_RecapAvo.Name = "dataGridView_RecapAvo";
            this.dataGridView_RecapAvo.ReadOnly = true;
            this.dataGridView_RecapAvo.Size = new System.Drawing.Size(347, 190);
            this.dataGridView_RecapAvo.TabIndex = 70;
            this.dataGridView_RecapAvo.TabStop = false;
            this.dataGridView_RecapAvo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapAvo_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Diplome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button_IntroRDV
            // 
            this.button_IntroRDV.Enabled = false;
            this.button_IntroRDV.Location = new System.Drawing.Point(107, 166);
            this.button_IntroRDV.Name = "button_IntroRDV";
            this.button_IntroRDV.Size = new System.Drawing.Size(101, 23);
            this.button_IntroRDV.TabIndex = 111;
            this.button_IntroRDV.Text = "Nouveau RDV";
            this.button_IntroRDV.UseVisualStyleBackColor = true;
            this.button_IntroRDV.Click += new System.EventHandler(this.button_IntroRDV_Click);
            // 
            // Column_NoDos
            // 
            this.Column_NoDos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_NoDos.HeaderText = "No Dos";
            this.Column_NoDos.Name = "Column_NoDos";
            this.Column_NoDos.ReadOnly = true;
            this.Column_NoDos.Width = 50;
            // 
            // TypRdv
            // 
            this.TypRdv.HeaderText = "Type";
            this.TypRdv.Name = "TypRdv";
            this.TypRdv.ReadOnly = true;
            this.TypRdv.Width = 75;
            // 
            // Column_DatRdv
            // 
            this.Column_DatRdv.HeaderText = "Date";
            this.Column_DatRdv.Name = "Column_DatRdv";
            this.Column_DatRdv.ReadOnly = true;
            // 
            // Column_TimRdv
            // 
            this.Column_TimRdv.HeaderText = "Heure";
            this.Column_TimRdv.Name = "Column_TimRdv";
            this.Column_TimRdv.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Width = 75;
            // 
            // Juge
            // 
            this.Juge.HeaderText = "Juge";
            this.Juge.Name = "Juge";
            this.Juge.ReadOnly = true;
            this.Juge.Width = 75;
            // 
            // Jury
            // 
            this.Jury.HeaderText = "Jury";
            this.Jury.Name = "Jury";
            this.Jury.ReadOnly = true;
            this.Jury.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Jury.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jury.Width = 50;
            // 
            // Form_Avo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 475);
            this.Controls.Add(this.button_IntroRDV);
            this.Controls.Add(this.dataGridView_RecapAvo);
            this.Controls.Add(this.dataGridView_RecapRdv);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.groupBox_Avo);
            this.Name = "Form_Avo";
            this.Text = "Gestion des Avocats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdv)).EndInit();
            this.groupBox_Avo.ResumeLayout(false);
            this.groupBox_Avo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapAvo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.DataGridView dataGridView_RecapRdv;
        private System.Windows.Forms.GroupBox groupBox_Avo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DatAvo;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label_DatAvo;
        private System.Windows.Forms.Label label_Nom;
        private System.Windows.Forms.Button button_ValAvo;
        private System.Windows.Forms.Button button_Cancel_Avo;
        private System.Windows.Forms.DataGridView dataGridView_RecapAvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button_IntroRDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DatRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jury;
    }
}

