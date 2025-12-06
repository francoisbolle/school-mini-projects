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
            this.dataGridView_RecapRdvCli = new System.Windows.Forms.DataGridView();
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
            this.dataGridView_RecapRdvTrib = new System.Windows.Forms.DataGridView();
            this.dataGridView_RecapRdvPlaid = new System.Windows.Forms.DataGridView();
            this.label_datagrid_RDV_client = new System.Windows.Forms.Label();
            this.label_RDV_Trib = new System.Windows.Forms.Label();
            this.label_DataGrid_RDV_Plaid = new System.Windows.Forms.Label();
            this.Column_NoDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DatRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimRdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvCli)).BeginInit();
            this.groupBox_Avo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapAvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvTrib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvPlaid)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(17, 185);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 110;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // dataGridView_RecapRdvCli
            // 
            this.dataGridView_RecapRdvCli.AllowUserToAddRows = false;
            this.dataGridView_RecapRdvCli.AllowUserToDeleteRows = false;
            this.dataGridView_RecapRdvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecapRdvCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NoDos,
            this.Column_DatRdv,
            this.Column_TimRdv});
            this.dataGridView_RecapRdvCli.Location = new System.Drawing.Point(58, 240);
            this.dataGridView_RecapRdvCli.Name = "dataGridView_RecapRdvCli";
            this.dataGridView_RecapRdvCli.ReadOnly = true;
            this.dataGridView_RecapRdvCli.Size = new System.Drawing.Size(296, 151);
            this.dataGridView_RecapRdvCli.TabIndex = 70;
            this.dataGridView_RecapRdvCli.TabStop = false;
            this.dataGridView_RecapRdvCli.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapRdv_CellEnter);
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
            this.dataGridView_RecapAvo.Size = new System.Drawing.Size(346, 190);
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
            this.button_IntroRDV.Location = new System.Drawing.Point(111, 185);
            this.button_IntroRDV.Name = "button_IntroRDV";
            this.button_IntroRDV.Size = new System.Drawing.Size(94, 23);
            this.button_IntroRDV.TabIndex = 111;
            this.button_IntroRDV.Text = "Nouveau RDV";
            this.button_IntroRDV.UseVisualStyleBackColor = true;
            this.button_IntroRDV.Click += new System.EventHandler(this.button_IntroRDV_Click);
            // 
            // dataGridView_RecapRdvTrib
            // 
            this.dataGridView_RecapRdvTrib.AllowUserToAddRows = false;
            this.dataGridView_RecapRdvTrib.AllowUserToDeleteRows = false;
            this.dataGridView_RecapRdvTrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecapRdvTrib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView_RecapRdvTrib.Location = new System.Drawing.Point(58, 431);
            this.dataGridView_RecapRdvTrib.Name = "dataGridView_RecapRdvTrib";
            this.dataGridView_RecapRdvTrib.ReadOnly = true;
            this.dataGridView_RecapRdvTrib.Size = new System.Drawing.Size(448, 151);
            this.dataGridView_RecapRdvTrib.TabIndex = 70;
            this.dataGridView_RecapRdvTrib.TabStop = false;
            this.dataGridView_RecapRdvTrib.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapRdv_CellEnter);
            // 
            // dataGridView_RecapRdvPlaid
            // 
            this.dataGridView_RecapRdvPlaid.AllowUserToAddRows = false;
            this.dataGridView_RecapRdvPlaid.AllowUserToDeleteRows = false;
            this.dataGridView_RecapRdvPlaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RecapRdvPlaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView_RecapRdvPlaid.Location = new System.Drawing.Point(58, 613);
            this.dataGridView_RecapRdvPlaid.Name = "dataGridView_RecapRdvPlaid";
            this.dataGridView_RecapRdvPlaid.ReadOnly = true;
            this.dataGridView_RecapRdvPlaid.Size = new System.Drawing.Size(495, 151);
            this.dataGridView_RecapRdvPlaid.TabIndex = 70;
            this.dataGridView_RecapRdvPlaid.TabStop = false;
            this.dataGridView_RecapRdvPlaid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RecapRdv_CellEnter);
            // 
            // label_datagrid_RDV_client
            // 
            this.label_datagrid_RDV_client.AutoSize = true;
            this.label_datagrid_RDV_client.Location = new System.Drawing.Point(9, 224);
            this.label_datagrid_RDV_client.Name = "label_datagrid_RDV_client";
            this.label_datagrid_RDV_client.Size = new System.Drawing.Size(77, 13);
            this.label_datagrid_RDV_client.TabIndex = 112;
            this.label_datagrid_RDV_client.Text = "RDV CLIENT :";
            // 
            // label_RDV_Trib
            // 
            this.label_RDV_Trib.AutoSize = true;
            this.label_RDV_Trib.Location = new System.Drawing.Point(9, 408);
            this.label_RDV_Trib.Name = "label_RDV_Trib";
            this.label_RDV_Trib.Size = new System.Drawing.Size(93, 13);
            this.label_RDV_Trib.TabIndex = 113;
            this.label_RDV_Trib.Text = "RDV TRIBUNAL :";
            // 
            // label_DataGrid_RDV_Plaid
            // 
            this.label_DataGrid_RDV_Plaid.AutoSize = true;
            this.label_DataGrid_RDV_Plaid.Location = new System.Drawing.Point(13, 585);
            this.label_DataGrid_RDV_Plaid.Name = "label_DataGrid_RDV_Plaid";
            this.label_DataGrid_RDV_Plaid.Size = new System.Drawing.Size(99, 13);
            this.label_DataGrid_RDV_Plaid.TabIndex = 114;
            this.label_DataGrid_RDV_Plaid.Text = "RDV PLAIDOIRIE :";
            // 
            // Column_NoDos
            // 
            this.Column_NoDos.HeaderText = "No Dos";
            this.Column_NoDos.Name = "Column_NoDos";
            this.Column_NoDos.ReadOnly = true;
            this.Column_NoDos.Width = 50;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "No Dos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Heure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Juge";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "No Dos";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Heure";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 75;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Juge";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 75;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Jury";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // Form_Avo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 791);
            this.Controls.Add(this.label_DataGrid_RDV_Plaid);
            this.Controls.Add(this.label_RDV_Trib);
            this.Controls.Add(this.label_datagrid_RDV_client);
            this.Controls.Add(this.button_IntroRDV);
            this.Controls.Add(this.dataGridView_RecapAvo);
            this.Controls.Add(this.dataGridView_RecapRdvPlaid);
            this.Controls.Add(this.dataGridView_RecapRdvTrib);
            this.Controls.Add(this.dataGridView_RecapRdvCli);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.groupBox_Avo);
            this.Name = "Form_Avo";
            this.Text = "Gestion des Avocats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvCli)).EndInit();
            this.groupBox_Avo.ResumeLayout(false);
            this.groupBox_Avo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapAvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvTrib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RecapRdvPlaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.DataGridView dataGridView_RecapRdvCli;
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
        private System.Windows.Forms.DataGridView dataGridView_RecapRdvTrib;
        private System.Windows.Forms.DataGridView dataGridView_RecapRdvPlaid;
        private System.Windows.Forms.Label label_datagrid_RDV_client;
        private System.Windows.Forms.Label label_RDV_Trib;
        private System.Windows.Forms.Label label_DataGrid_RDV_Plaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NoDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DatRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimRdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}

