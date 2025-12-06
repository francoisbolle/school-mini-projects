using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTRV
{
    public partial class Form_Rdv : Form
    {
        public Form_Rdv(avo t_avo)
        {
            InitializeComponent();
            this.inter_rdv = new rdv();
            this.inter_rdvTrib = new rdvTrib();
            this.inter_rdvPlaid = new rdvPlaid();
            this.dateTimePicker_DatRdv.MinDate = DateTime.Now;
            this.dateTimePicker_DatRdv.MaxDate = DateTime.Now.AddYears(2);
            this.avo_persist = t_avo;
        }

        private void Form_Rdv_Load(object sender, EventArgs e)
        {
            this.comboBox_type_RDV.SelectedIndex = 0;
        }

        private void textBox_NoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.button_ValRdv_Click(sender, e);
        }

        private void button_ValRdv_Click(object sender, EventArgs e)
        {
            switch (this.comboBox_type_RDV.SelectedIndex)  // 0-> simple / 1-> Trib / 2-> Plaid
            {
                case 0:
                    try
                    {
                        this.inter_rdv.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                        this.inter_rdv.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                        this.inter_rdv.set_TimRdv(this.dateTimePicker_TimRdv.Text);
                        this.inter_rdv.set_TypRdv(this.comboBox_type_RDV.SelectedIndex);

                        this.avo_persist.add_rdv(this.inter_rdv);
                        //this.button_CancelRdv_Click(sender, e);
                    }
                    catch (Invalid_Value exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.mess, "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (FormatException exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.Message, "Erreur d'encodage - Valeur numérique uniquement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (OutOfMemoryException exc)
                    {
                        MessageBox.Show("Mémoire saturée - Libérer des ressources et recommencer: " + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //if (this.Trdv.Last() == null) Array.Clear(this.Trdv, this.Trdv.Length - 1, 1); //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                    }
                    break;

                case 1:
                    try
                    {
                        this.inter_rdvTrib.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                        this.inter_rdvTrib.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                        this.inter_rdvTrib.set_TimRdv(this.dateTimePicker_TimRdv.Text);
                        this.inter_rdvTrib.set_TypRdv(this.comboBox_type_RDV.SelectedIndex);
                        this.inter_rdvTrib.set_ville(this.textBox_Ville.Text);
                        this.inter_rdvTrib.set_juge(this.textBox_Juge.Text);

                        this.avo_persist.add_rdvTrib(this.inter_rdvTrib);
                        //this.button_CancelRdv_Click(sender, e);
                    }
                    catch (Invalid_Value exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.mess, "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (FormatException exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.Message, "Erreur d'encodage - Valeur numérique uniquement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (OutOfMemoryException exc)
                    {
                        MessageBox.Show("Mémoire saturée - Libérer des ressources et recommencer: " + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //if (this.Trdv.Last() == null) Array.Clear(this.Trdv, this.Trdv.Length - 1, 1); //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                    }
                    break;

                case 2:
                    try
                    {
                        this.inter_rdvPlaid.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                        this.inter_rdvPlaid.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                        this.inter_rdvPlaid.set_TimRdv(this.dateTimePicker_TimRdv.Text);
                        this.inter_rdvPlaid.set_TypRdv(this.comboBox_type_RDV.SelectedIndex);
                        this.inter_rdvPlaid.set_ville(this.textBox_Ville.Text);
                        this.inter_rdvPlaid.set_juge(this.textBox_Juge.Text);
                        this.inter_rdvPlaid.set_jury(this.checkBox_Jury.Checked);
                                
                        this.avo_persist.add_rdvPlaid(this.inter_rdvPlaid);
                        //this.button_CancelRdv_Click(sender, e);
                    }
                    catch (Invalid_Value exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.mess, "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (FormatException exc)
                    {
                        MessageBox.Show("No Dossier : " + exc.Message, "Erreur d'encodage - Valeur numérique uniquement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                        //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
                    }
                    catch (OutOfMemoryException exc)
                    {
                        MessageBox.Show("Mémoire saturée - Libérer des ressources et recommencer: " + exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //if (this.Trdv.Last() == null) Array.Clear(this.Trdv, this.Trdv.Length - 1, 1); //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox_NoDos.Focus();
                        this.textBox_NoDos.SelectAll();
                    }
                    break;

            }
        }

        private void textBox_NoDos_TextChanged(object sender, EventArgs e)
        {
            this.button_ValRdv.Enabled = this.textBox_NoDos.Text.Length != 0;
        }

        private void button_CancelRdv_Click(object sender, EventArgs e)
        {
            //this.dateTimePicker_DatRdv.ResetText();
            //this.dateTimePicker_TimRdv.ResetText();
            //this.textBox_NoDos.Clear();
            //this.textBox_NoDos.Focus();
            //this.comboBox_type_RDV.SelectedIndex = -1;
        }

        private void comboBox_type_RDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBox_type_RDV.SelectedIndex)  // 0-> simple / 1-> Trib / 2-> Plaid
            //switch(((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    this.textBox_Juge.Visible = this.textBox_Ville.Visible = this.label_Juge.Visible = this.label_Ville.Visible = this.checkBox_Jury.Visible = false;
                    break;

                case 1: 
                    this.textBox_Juge.Visible = this.textBox_Ville.Visible = this.label_Juge.Visible = this.label_Ville.Visible  = true;
                    this.checkBox_Jury.Visible = false;
                    break;

                case 2:
                    this.textBox_Juge.Visible = this.textBox_Ville.Visible = this.label_Juge.Visible = this.label_Ville.Visible = this.checkBox_Jury.Visible = true;
                    break;
            }
        }
    }
}
