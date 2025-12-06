namespace PrjTRV
{
    partial class Form_Rdv
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        private rdv [] Trdv;
         
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
            this.groupBox_IntroRdv = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_DatRdv = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_TimRdv = new System.Windows.Forms.DateTimePicker();
            this.textBox_NoDos = new System.Windows.Forms.TextBox();
            this.label_TimRdv = new System.Windows.Forms.Label();
            this.label_DatRdv = new System.Windows.Forms.Label();
            this.label_NoDos = new System.Windows.Forms.Label();
            this.button_ValRdv = new System.Windows.Forms.Button();
            this.button_CancelRdv = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.dataGridView_RecapRdv = new System.Windows.Forms.DataGridView();
            this.Column_NoDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DatRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_IntroRdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_IntroRdv
            // 
            this.groupBox_IntroRdv.Controls.Add(this.dateTimePicker_DatRdv);
            this.groupBox_IntroRdv.Controls.Add(this.dateTimePicker_TimRdv);
            this.groupBox_IntroRdv.Controls.Add(this.textBox_NoDos);
            this.groupBox_IntroRdv.Controls.Add(this.label_TimRdv);
            this.groupBox_IntroRdv.Controls.Add(this.label_DatRdv);
            this.groupBox_IntroRdv.Controls.Add(this.label_NoDos);
            this.groupBox_IntroRdv.Controls.Add(this.button_ValRdv);
            this.groupBox_IntroRdv.Controls.Add(this.button_CancelRdv);
            this.groupBox_IntroRdv.Location = new System.Drawing.Point(12, 12);
            this.groupBox_IntroRdv.Name = "groupBox_IntroRdv";
            this.groupBox_IntroRdv.Size = new System.Drawing.Size(217, 156);
            this.groupBox_IntroRdv.TabIndex = 1;
            this.groupBox_IntroRdv.TabStop = false;
            this.groupBox_IntroRdv.Text = "Introduction RDV";
            // 
            // dateTimePicker_DatRdv
            // 
            this.dateTimePicker_DatRdv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DatRdv.Location = new System.Drawing.Point(102, 50);
            this.dateTimePicker_DatRdv.Name = "dateTimePicker_DatRdv";
            this.dateTimePicker_DatRdv.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker_DatRdv.TabIndex = 20;
            this.dateTimePicker_DatRdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // dateTimePicker_TimRdv
            // 
            this.dateTimePicker_TimRdv.CustomFormat = "HH:mm";
            this.dateTimePicker_TimRdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_TimRdv.Location = new System.Drawing.Point(119, 75);
            this.dateTimePicker_TimRdv.Name = "dateTimePicker_TimRdv";
            this.dateTimePicker_TimRdv.ShowUpDown = true;
            this.dateTimePicker_TimRdv.Size = new System.Drawing.Size(61, 20);
            this.dateTimePicker_TimRdv.TabIndex = 30;
            this.dateTimePicker_TimRdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // textBox_NoDos
            // 
            this.textBox_NoDos.Location = new System.Drawing.Point(102, 23);
            this.textBox_NoDos.Name = "textBox_NoDos";
            this.textBox_NoDos.Size = new System.Drawing.Size(78, 20);
            this.textBox_NoDos.TabIndex = 10;
            this.textBox_NoDos.TextChanged += new System.EventHandler(this.textBox_NoDos_TextChanged);
            this.textBox_NoDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // label_TimRdv
            // 
            this.label_TimRdv.AutoSize = true;
            this.label_TimRdv.Location = new System.Drawing.Point(14, 81);
            this.label_TimRdv.Name = "label_TimRdv";
            this.label_TimRdv.Size = new System.Drawing.Size(36, 13);
            this.label_TimRdv.TabIndex = 1;
            this.label_TimRdv.Text = "Heure";
            // 
            // label_DatRdv
            // 
            this.label_DatRdv.AutoSize = true;
            this.label_DatRdv.Location = new System.Drawing.Point(14, 58);
            this.label_DatRdv.Name = "label_DatRdv";
            this.label_DatRdv.Size = new System.Drawing.Size(30, 13);
            this.label_DatRdv.TabIndex = 1;
            this.label_DatRdv.Text = "Date";
            // 
            // label_NoDos
            // 
            this.label_NoDos.AutoSize = true;
            this.label_NoDos.Location = new System.Drawing.Point(14, 26);
            this.label_NoDos.Name = "label_NoDos";
            this.label_NoDos.Size = new System.Drawing.Size(82, 13);
            this.label_NoDos.TabIndex = 1;
            this.label_NoDos.Text = "Numéro Dossier";
            // 
            // button_ValRdv
            // 
            this.button_ValRdv.Enabled = false;
            this.button_ValRdv.Location = new System.Drawing.Point(105, 120);
            this.button_ValRdv.Name = "button_ValRdv";
            this.button_ValRdv.Size = new System.Drawing.Size(75, 23);
            this.button_ValRdv.TabIndex = 40;
            this.button_ValRdv.Text = "Valider";
            this.button_ValRdv.UseVisualStyleBackColor = true;
            this.button_ValRdv.Click += new System.EventHandler(this.button_ValRdv_Click);
            // 
            // button_CancelRdv
            // 
            this.button_CancelRdv.Location = new System.Drawing.Point(17, 120);
            this.button_CancelRdv.Name = "button_CancelRdv";
            this.button_CancelRdv.Size = new System.Drawing.Size(75, 23);
            this.button_CancelRdv.TabIndex = 50;
            this.button_CancelRdv.Text = "Annuler";
            this.button_CancelRdv.UseVisualStyleBackColor = true;
            this.button_CancelRdv.Click += new System.EventHandler(this.button_CancelRdv_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(12, 185);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 60;
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
            this.Column_DatRdv,
            this.Column_TimRdv});
            this.dataGridView_RecapRdv.Location = new System.Drawing.Point(235, 18);
            this.dataGridView_RecapRdv.Name = "dataGridView_RecapRdv";
            this.dataGridView_RecapRdv.ReadOnly = true;
            this.dataGridView_RecapRdv.Size = new System.Drawing.Size(347, 190);
            this.dataGridView_RecapRdv.TabIndex = 70;
            this.dataGridView_RecapRdv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapRdv_CellEnter);
            // 
            // Column_NoDos
            // 
            this.Column_NoDos.HeaderText = "No Dossier";
            this.Column_NoDos.Name = "Column_NoDos";
            this.Column_NoDos.ReadOnly = true;
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
            // Form_Rdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 220);
            this.Controls.Add(this.dataGridView_RecapRdv);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.groupBox_IntroRdv);
            this.Name = "Form_Rdv";
            this.Text = "Gestion des rendez-vous";
            this.groupBox_IntroRdv.ResumeLayout(false);
            this.groupBox_IntroRdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_IntroRdv;
        private System.Windows.Forms.TextBox textBox_NoDos;
        private System.Windows.Forms.Label label_TimRdv;
        private System.Windows.Forms.Label label_DatRdv;
        private System.Windows.Forms.Label label_NoDos;
        private System.Windows.Forms.Button button_ValRdv;
        private System.Windows.Forms.Button button_CancelRdv;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.DataGridView dataGridView_RecapRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DatRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimRdv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimRdv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DatRdv;
    }
}

