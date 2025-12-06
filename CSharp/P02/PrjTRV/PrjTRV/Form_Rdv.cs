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
        public Form_Rdv()
        {
            InitializeComponent();
            this.dateTimePicker_DatRdv.MinDate = DateTime.Now;
            this.dateTimePicker_DatRdv.MaxDate = DateTime.Now.AddYears(2);
            inter_rdv = new rdv();      // allocation d'une zone mémoire au "pointeur"
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
               
                //this.inter_rdv.set_NoD(this.textBox_NoDos.Text);
                this.inter_rdv.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                this.inter_rdv.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                this.inter_rdv.set_TimRdv(this.dateTimePicker_TimRdv.Text);
                this.dataGridView_RecapRdv.Rows.Add(this.inter_rdv.get_NoD().ToString(), 
                                                        this.inter_rdv.get_DatRdv(),
                                                            this.inter_rdv.get_TimRdv());
                this.dataGridView_RecapRdv.CurrentCell = this.dataGridView_RecapRdv[0, this.dataGridView_RecapRdv.RowCount - 1];
                this.button_CancelRdv_Click(sender, e);
            }
            catch(Invalid_Value exc)
            {
                MessageBox.Show("No Dossier : " + exc.mess, "Erreur d'encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_NoDos.Focus();
                this.textBox_NoDos.SelectAll();
            }
            catch(FormatException exc)
            {
                MessageBox.Show("No Dossier : " + exc.Message, "Erreur d'encodage - Valeur numérique uniquement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_NoDos.Focus();
                this.textBox_NoDos.SelectAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox_NoDos.Focus();
                this.textBox_NoDos.SelectAll();
            }
        }

        private void dataGridView_RecapRdv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_RecapRdv.Rows[e.RowIndex].Selected = true;
        }

        private void textBox_NoDos_TextChanged(object sender, EventArgs e)
        {
            this.button_ValRdv.Enabled = this.textBox_NoDos.Text.Length != 0;
        }
    }
}
