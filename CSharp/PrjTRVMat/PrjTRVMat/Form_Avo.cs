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
            this.inter_avo = new avo();
            Array.Resize(ref this.Tavo, 0); // initialisation du tableau de pointeur à "0"
        }


        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ValAvo_Click(object sender, EventArgs e)
        {
            this.inter_avo.set_nom(this.textBox_Nom.Text);
            this.inter_avo.set_datdip(this.dateTimePicker_DatAvo.Text);
            Array.Resize(ref this.Tavo, this.Tavo.Length + 1);
            this.Tavo[this.Tavo.Length - 1] = new avo(inter_avo);
            this.refresh_dataGridView_RecapAvo();
            this.button_Cancel_Avo_Click(sender, e);    // Appel explicite de l'évènement
            this.button_IntroRDV.Enabled = true;
            
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

        private void refresh_dataGridView_RecapAvo()
        {
            this.dataGridView_RecapAvo.Rows.Clear();
            for (int x = 0; x < this.Tavo.Length; x++)
                this.dataGridView_RecapAvo.Rows.Add(this.Tavo[x].get_nom(), this.Tavo[x].get_datdip());
            this.dataGridView_RecapAvo.CurrentCell = this.dataGridView_RecapAvo[0, this.dataGridView_RecapAvo.RowCount - 1];
        }

        private void refresh_dataGridView_RecapRdvCli(avo t_avo)
        {
                     

            this.dataGridView_RecapRdvCli.Rows.Clear();
            for (int x = 0; x < t_avo.get_TrdvSize(); x++)
            {
                
                this.dataGridView_RecapRdvCli.Rows.Add(t_avo.get_rdv(x).get_NoD().ToString(),
                                                            t_avo.get_rdv(x).get_DatRdv(),
                                                               t_avo.get_rdv(x).get_TimRdv());
                if (this.dataGridView_RecapRdvCli.RowCount > 0) this.dataGridView_RecapRdvCli.CurrentCell = this.dataGridView_RecapRdvCli[0, this.dataGridView_RecapRdvCli.RowCount - 1];
            }
        }

        private void refresh_dataGridView_RecapRdvTrib(avo t_avo)
        {


            this.dataGridView_RecapRdvTrib.Rows.Clear();
            for (int x = 0; x < t_avo.get_TrdvTribSize(); x++)
            {

                this.dataGridView_RecapRdvTrib.Rows.Add(t_avo.get_rdvTrib(x).get_NoD().ToString(),
                                                             t_avo.get_rdvTrib(x).get_DatRdv(),
                                                                t_avo.get_rdvTrib(x).get_TimRdv(),
                                                                   t_avo.get_rdvTrib(x).get_ville(),
                                                                     t_avo.get_rdvTrib(x).get_juge());
                if (this.dataGridView_RecapRdvTrib.RowCount > 0) this.dataGridView_RecapRdvTrib.CurrentCell = this.dataGridView_RecapRdvTrib[0, this.dataGridView_RecapRdvTrib.RowCount - 1];
            }
        }

        private void refresh_dataGridView_RecapRdvPlaid(avo t_avo)
        {


            this.dataGridView_RecapRdvPlaid.Rows.Clear();
            for (int x = 0; x < t_avo.get_TrdvPlaidSize(); x++)
            {
                string t_jury = "-";
                if (t_avo.get_rdvPlaid(x).get_jury()) t_jury = "oui";
                else t_jury = "non";

                this.dataGridView_RecapRdvPlaid.Rows.Add(t_avo.get_rdvPlaid(x).get_NoD().ToString(),
                                                            t_avo.get_rdvPlaid(x).get_DatRdv(),
                                                               t_avo.get_rdvPlaid(x).get_TimRdv(),
                                                                  t_avo.get_rdvPlaid(x).get_ville(),
                                                                    t_avo.get_rdvPlaid(x).get_juge(), t_jury);
                if (this.dataGridView_RecapRdvPlaid.RowCount > 0) this.dataGridView_RecapRdvPlaid.CurrentCell = this.dataGridView_RecapRdvPlaid[0, this.dataGridView_RecapRdvPlaid.RowCount - 1];
            }
        }

        private void dataGridView_RecapAvo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_RecapAvo.Rows[e.RowIndex].Selected = true;
            
                 
                        this.refresh_dataGridView_RecapRdvCli(this.Tavo[e.RowIndex]);
                         
                
                     
                        this.refresh_dataGridView_RecapRdvTrib(this.Tavo[e.RowIndex]);
                         
                    
                     
                        this.refresh_dataGridView_RecapRdvPlaid(this.Tavo[e.RowIndex]);
                        
                 
            
             
            this.current_avo = e.RowIndex;
        }

        private void dataGridView_RecapRdv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            ((DataGridView)sender).Rows[e.RowIndex].Selected = true;

        }

        

        private void button_IntroRDV_Click(object sender, EventArgs e)
        {
            Form_Rdv t_Frdv = new Form_Rdv(this.Tavo[this.current_avo]);  // instanciation du formulaire secondaire

            if (t_Frdv.ShowDialog() == DialogResult.OK)
            {

                switch (t_Frdv.comboBox_type_RDV.SelectedIndex)  // 0-> simple / 1-> Trib / 2-> Plaid
                {

                    case 0:
                        this.refresh_dataGridView_RecapRdvCli(this.Tavo[this.current_avo]);
                        break;

                    case 1:
                        this.refresh_dataGridView_RecapRdvTrib(this.Tavo[this.current_avo]);
                        break;

                    case 2:
                        this.refresh_dataGridView_RecapRdvPlaid(this.Tavo[this.current_avo]);
                        break;

                }
            }


        }
       
    }
}
