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
            Array.Resize(ref this.Trdv, 0);
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
                // V1 ==> Gestion via objet indépendant
                rdv t_rdv;  // "pointeur" temporaire

                t_rdv = new rdv();
                t_rdv.set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                t_rdv.set_DatRdv(this.dateTimePicker_DatRdv.Text);
                t_rdv.set_TimRdv(this.dateTimePicker_TimRdv.Text);

                Array.Resize(ref this.Trdv, this.Trdv.Length + 1);
                //this.Trdv[this.Trdv.Length - 1] = t_rdv;            // transfert d'adresses entre "pointeurs"
                this.Trdv[this.Trdv.Length - 1] = new rdv(t_rdv); // copie de la zone mémoire initiale via le constructeur par copie
                 

                // V2 ==> Gestion directe sur le tableau

                //Array.Resize(ref this.Trdv, 2147483647);
                //Array.Resize(ref this.Trdv, this.Trdv.Length + 1);
                //this.Trdv[this.Trdv.Length - 1] = new rdv();
                //this.Trdv[this.Trdv.Length - 1].set_NoD(Convert.ToInt16(this.textBox_NoDos.Text));
                //this.Trdv[this.Trdv.Length - 1].set_DatRdv(this.dateTimePicker_DatRdv.Text);
                //this.Trdv[this.Trdv.Length - 1].set_TimRdv(this.dateTimePicker_TimRdv.Text);

                this.refresh_dataGridView_RecapRdv(sender, e);
                 
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
                if (this.Trdv.Last() == null) Array.Clear(this.Trdv, this.Trdv.Length - 1, 1); //Array.Resize(ref this.Trdv, this.Trdv.Length - 1);
            }
            catch (Exception exc)
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

        private void refresh_dataGridView_RecapRdv(object sender, EventArgs e)
        {
            this.dataGridView_RecapRdv.Rows.Clear();
            for (int x = 0; x < this.Trdv.Length; x++) this.dataGridView_RecapRdv.Rows.Add(this.Trdv[x].get_NoD().ToString(),
                                                            this.Trdv[x].get_DatRdv(),
                                                                this.Trdv[x].get_TimRdv());
            this.dataGridView_RecapRdv.CurrentCell = this.dataGridView_RecapRdv[0, this.dataGridView_RecapRdv.RowCount - 1];
            this.button_CancelRdv_Click(sender, e);
        }

        private void textBox_NoDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.button_ValRdv_Click(sender, e);
        }
    }
}
