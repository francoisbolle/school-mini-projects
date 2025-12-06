namespace PrjTRV
{
    partial class Form_Rdv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        rdv inter_rdv;  // pointeur classe mère
        avo avo_persist;

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
            this.button_CancelRdv = new System.Windows.Forms.Button();
            this.button_ValRdv = new System.Windows.Forms.Button();
            this.label_NoDos = new System.Windows.Forms.Label();
            this.label_DatRdv = new System.Windows.Forms.Label();
            this.label_TimRdv = new System.Windows.Forms.Label();
            this.textBox_NoDos = new System.Windows.Forms.TextBox();
            this.dateTimePicker_TimRdv = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DatRdv = new System.Windows.Forms.DateTimePicker();
            this.comboBox_TypRdv = new System.Windows.Forms.ComboBox();
            this.label_TypRdv = new System.Windows.Forms.Label();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label_Ville = new System.Windows.Forms.Label();
            this.textBox_Juge = new System.Windows.Forms.TextBox();
            this.label_Juge = new System.Windows.Forms.Label();
            this.checkBox_Jury = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_CancelRdv
            // 
            this.button_CancelRdv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_CancelRdv.Location = new System.Drawing.Point(15, 200);
            this.button_CancelRdv.Name = "button_CancelRdv";
            this.button_CancelRdv.Size = new System.Drawing.Size(75, 23);
            this.button_CancelRdv.TabIndex = 100;
            this.button_CancelRdv.Text = "Annuler";
            this.button_CancelRdv.UseVisualStyleBackColor = true;
            this.button_CancelRdv.Click += new System.EventHandler(this.button_CancelRdv_Click);
            // 
            // button_ValRdv
            // 
            this.button_ValRdv.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ValRdv.Enabled = false;
            this.button_ValRdv.Location = new System.Drawing.Point(167, 200);
            this.button_ValRdv.Name = "button_ValRdv";
            this.button_ValRdv.Size = new System.Drawing.Size(75, 23);
            this.button_ValRdv.TabIndex = 90;
            this.button_ValRdv.Text = "Valider";
            this.button_ValRdv.UseVisualStyleBackColor = true;
            this.button_ValRdv.Click += new System.EventHandler(this.button_ValRdv_Click);
            // 
            // label_NoDos
            // 
            this.label_NoDos.AutoSize = true;
            this.label_NoDos.Location = new System.Drawing.Point(12, 20);
            this.label_NoDos.Name = "label_NoDos";
            this.label_NoDos.Size = new System.Drawing.Size(82, 13);
            this.label_NoDos.TabIndex = 1;
            this.label_NoDos.Text = "Numéro Dossier";
            // 
            // label_DatRdv
            // 
            this.label_DatRdv.AutoSize = true;
            this.label_DatRdv.Location = new System.Drawing.Point(57, 50);
            this.label_DatRdv.Name = "label_DatRdv";
            this.label_DatRdv.Size = new System.Drawing.Size(30, 13);
            this.label_DatRdv.TabIndex = 1;
            this.label_DatRdv.Text = "Date";
            // 
            // label_TimRdv
            // 
            this.label_TimRdv.AutoSize = true;
            this.label_TimRdv.Location = new System.Drawing.Point(51, 75);
            this.label_TimRdv.Name = "label_TimRdv";
            this.label_TimRdv.Size = new System.Drawing.Size(36, 13);
            this.label_TimRdv.TabIndex = 1;
            this.label_TimRdv.Text = "Heure";
            // 
            // textBox_NoDos
            // 
            this.textBox_NoDos.Location = new System.Drawing.Point(100, 17);
            this.textBox_NoDos.Name = "textBox_NoDos";
            this.textBox_NoDos.Size = new System.Drawing.Size(78, 20);
            this.textBox_NoDos.TabIndex = 60;
            this.textBox_NoDos.TextChanged += new System.EventHandler(this.textBox_NoDos_TextChanged);
            this.textBox_NoDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // dateTimePicker_TimRdv
            // 
            this.dateTimePicker_TimRdv.CustomFormat = "HH:mm";
            this.dateTimePicker_TimRdv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_TimRdv.Location = new System.Drawing.Point(117, 69);
            this.dateTimePicker_TimRdv.Name = "dateTimePicker_TimRdv";
            this.dateTimePicker_TimRdv.ShowUpDown = true;
            this.dateTimePicker_TimRdv.Size = new System.Drawing.Size(61, 20);
            this.dateTimePicker_TimRdv.TabIndex = 80;
            this.dateTimePicker_TimRdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // dateTimePicker_DatRdv
            // 
            this.dateTimePicker_DatRdv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DatRdv.Location = new System.Drawing.Point(100, 44);
            this.dateTimePicker_DatRdv.Name = "dateTimePicker_DatRdv";
            this.dateTimePicker_DatRdv.Size = new System.Drawing.Size(78, 20);
            this.dateTimePicker_DatRdv.TabIndex = 70;
            this.dateTimePicker_DatRdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // comboBox_TypRdv
            // 
            this.comboBox_TypRdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypRdv.FormattingEnabled = true;
            this.comboBox_TypRdv.Items.AddRange(new object[] {
            "Clientèle",
            "Tribunal",
            "Plaidoirie"});
            this.comboBox_TypRdv.Location = new System.Drawing.Point(103, 100);
            this.comboBox_TypRdv.Name = "comboBox_TypRdv";
            this.comboBox_TypRdv.Size = new System.Drawing.Size(82, 21);
            this.comboBox_TypRdv.TabIndex = 82;
            this.comboBox_TypRdv.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypRdv_SelectedIndexChanged);
            // 
            // label_TypRdv
            // 
            this.label_TypRdv.AutoSize = true;
            this.label_TypRdv.Location = new System.Drawing.Point(12, 103);
            this.label_TypRdv.Name = "label_TypRdv";
            this.label_TypRdv.Size = new System.Drawing.Size(72, 13);
            this.label_TypRdv.TabIndex = 1;
            this.label_TypRdv.Text = "Type de RDV";
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(60, 137);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(125, 20);
            this.textBox_Ville.TabIndex = 84;
            this.textBox_Ville.Visible = false;
            this.textBox_Ville.TextChanged += new System.EventHandler(this.textBox_NoDos_TextChanged);
            this.textBox_Ville.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // label_Ville
            // 
            this.label_Ville.AutoSize = true;
            this.label_Ville.Location = new System.Drawing.Point(19, 140);
            this.label_Ville.Name = "label_Ville";
            this.label_Ville.Size = new System.Drawing.Size(26, 13);
            this.label_Ville.TabIndex = 1;
            this.label_Ville.Text = "Ville";
            this.label_Ville.Visible = false;
            // 
            // textBox_Juge
            // 
            this.textBox_Juge.Location = new System.Drawing.Point(60, 163);
            this.textBox_Juge.Name = "textBox_Juge";
            this.textBox_Juge.Size = new System.Drawing.Size(125, 20);
            this.textBox_Juge.TabIndex = 86;
            this.textBox_Juge.Visible = false;
            this.textBox_Juge.TextChanged += new System.EventHandler(this.textBox_NoDos_TextChanged);
            this.textBox_Juge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NoDos_KeyPress);
            // 
            // label_Juge
            // 
            this.label_Juge.AutoSize = true;
            this.label_Juge.Location = new System.Drawing.Point(19, 166);
            this.label_Juge.Name = "label_Juge";
            this.label_Juge.Size = new System.Drawing.Size(30, 13);
            this.label_Juge.TabIndex = 1;
            this.label_Juge.Text = "Juge";
            this.label_Juge.Visible = false;
            // 
            // checkBox_Jury
            // 
            this.checkBox_Jury.AutoSize = true;
            this.checkBox_Jury.Location = new System.Drawing.Point(197, 165);
            this.checkBox_Jury.Name = "checkBox_Jury";
            this.checkBox_Jury.Size = new System.Drawing.Size(45, 17);
            this.checkBox_Jury.TabIndex = 88;
            this.checkBox_Jury.Text = "Jury";
            this.checkBox_Jury.UseVisualStyleBackColor = true;
            this.checkBox_Jury.Visible = false;
            // 
            // Form_Rdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.checkBox_Jury);
            this.Controls.Add(this.comboBox_TypRdv);
            this.Controls.Add(this.dateTimePicker_DatRdv);
            this.Controls.Add(this.dateTimePicker_TimRdv);
            this.Controls.Add(this.label_Juge);
            this.Controls.Add(this.textBox_Juge);
            this.Controls.Add(this.label_Ville);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.label_NoDos);
            this.Controls.Add(this.textBox_NoDos);
            this.Controls.Add(this.button_CancelRdv);
            this.Controls.Add(this.label_TypRdv);
            this.Controls.Add(this.label_TimRdv);
            this.Controls.Add(this.button_ValRdv);
            this.Controls.Add(this.label_DatRdv);
            this.Name = "Form_Rdv";
            this.Text = "Intro RDV";
            this.Load += new System.EventHandler(this.Form_Rdv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CancelRdv;
        private System.Windows.Forms.Button button_ValRdv;
        private System.Windows.Forms.Label label_NoDos;
        private System.Windows.Forms.Label label_DatRdv;
        private System.Windows.Forms.Label label_TimRdv;
        private System.Windows.Forms.TextBox textBox_NoDos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TimRdv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DatRdv;
        private System.Windows.Forms.ComboBox comboBox_TypRdv;
        private System.Windows.Forms.Label label_TypRdv;
        private System.Windows.Forms.TextBox textBox_Ville;
        private System.Windows.Forms.Label label_Ville;
        private System.Windows.Forms.TextBox textBox_Juge;
        private System.Windows.Forms.Label label_Juge;
        private System.Windows.Forms.CheckBox checkBox_Jury;

    }
}