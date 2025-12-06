using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// ENCODAGE AVO AVEC MAJ DE DATAGRID
// ENCODAGE RDV SUR AVO SELECTIONNE SUR DATAGRID_AVO
// MAJ DATAGRID_RDV SELON AVO SELECTIONNE EN DATAGRID_AVO
// SECURISATION AJOUT AVO : min 2 car sur le nom 


namespace PrjTRV
{
    public partial class Form_Avo : Form
    {
        public Form_Avo()
        {
            InitializeComponent();
            this.dateTimePicker_DatRdv.MinDate = DateTime.Now;
            this.dateTimePicker_DatRdv.MaxDate = DateTime.Now.AddYears(2);
            this.inter_avo = new avo();
            this.inter_rdv = new rdv();
        }

        private void button_CancelRdv_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_DatRdv.ResetText();
            this.dateTimePicker_TimRdv.ResetText();
            this.textBox_NoDos.Clear();
            this.textBox_NoDos.Focus();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ValRdv_Click(object sender, EventArgs e)
        {
            try
            {
                inter_rdv.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                inter_rdv.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                inter_rdv.set_TimRdv(this.dateTimePicker_TimRdv.Text);
                this.inter_avo.add_rdv(this.inter_rdv);
                this.refresh_dataGridView_RecapRdv();
                this.button_CancelRdv_Click(sender, e); 
            }
            catch(Invalid_Value exc)
            {
                MessageBox.Show("No Dossier : " + exc.mess, "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_NoDos.Focus();
                this.textBox_NoDos.SelectAll();
                //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
            }
            catch(FormatException exc)
            {
                MessageBox.Show("No Dossier : " + exc.Message, "Erreur d'encodage - Valeur numérique uniquement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_NoDos.Focus();
                this.textBox_NoDos.SelectAll();
                //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);  // V2 ONLY
            }
            catch(OutOfMemoryException exc)
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
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var DGVtemp = (DataGridView) sender;   
            DGVtemp.Rows[e.RowIndex].Selected = true;
        }

        private void textBox_NoDos_TextChanged(object sender, EventArgs e)
        {
            this.button_ValRdv.Enabled = this.textBox_NoDos.Text.Length != 0;
        }

        private void refresh_dataGridView_RecapRdv()
        {
            this.dataGridView_RecapRdv.Rows.Clear();
            for (int x = 0; x < this.inter_avo.get_TrdvSize(); x++) 
                this.dataGridView_RecapRdv.Rows.Add(this.inter_avo.get_rdv(x).get_NoD().ToString(),
                                                            this.inter_avo.get_rdv(x).get_DatRdv(),
                                                               this.inter_avo.get_rdv(x).get_TimRdv());
            this.dataGridView_RecapRdv.CurrentCell = this.dataGridView_RecapRdv[0, this.dataGridView_RecapRdv.RowCount - 1];
        }

        private void textBox_NoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.button_ValRdv_Click(sender, e);
        }

        private void button_ValAvo_Click(object sender, EventArgs e)
        {
            this.inter_avo.set_nom(this.textBox_Nom.Text);
            this.inter_avo.set_datdip(this.dateTimePicker_DatAvo.Text);
            this.dataGridView_RecapAvo.Rows.Add(this.inter_avo.get_nom(), this.inter_avo.get_datdip());
            this.dataGridView_RecapAvo.CurrentCell = this.dataGridView_RecapAvo[0, this.dataGridView_RecapAvo.RowCount - 1];    // Appel implicite de l'évènement cell_enter
            this.button_Cancel_Avo_Click(sender, e);    // Appel explicite de l'évènement
            this.groupBox_IntroRdv.Enabled = true;
            this.groupBox_Avo.Enabled = false;
        }

        private void button_Cancel_Avo_Click(object sender, EventArgs e)
        {
            this.dateTimePicker_DatAvo.ResetText();
            this.textBox_Nom.Clear();
            this.textBox_Nom.Focus();
        }

        private void textBox_Nom_TextChanged(object sender, EventArgs e)
        {
            this.button_ValAvo.Enabled =  this.textBox_Nom.TextLength > 1;
        }


       
    }
}
