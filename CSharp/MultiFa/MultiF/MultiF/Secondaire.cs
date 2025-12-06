using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiF
{
    public partial class Secondaire : Form
    {
        public Secondaire(Loc t_Loc, TextBox t_TbVille, TextBox t_TbTypLoc)
        {
            InitializeComponent();
            //test = new Loc();
            this.Loc_Persist = t_Loc;   // transfert des coordonnées de la cible vers le Principal
            this.TbVille_Persist = t_TbVille;
            this.TbTypLoc_Persist = t_TbTypLoc;
        }

        private void button_Val_Click(object sender, EventArgs e)
        {
            //this.test.set_ville(this.textBox_Ville.Text);
            //this.test.appart = this.checkBox_Appart.Checked;
            this.Loc_Persist.set_ville(this.textBox_Ville.Text);
            this.Loc_Persist.appart = this.checkBox_Appart.Checked;
            
            this.TbVille_Persist.Text = this.Loc_Persist.get_ville();
            if (this.Loc_Persist.appart) this.TbTypLoc_Persist.Text = "Appartement";
            else this.TbTypLoc_Persist.Text = "Maison";

            this.button_Cancel_Click(sender, e);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.checkBox_Appart.Checked = false;
            this.textBox_Ville.Clear();
            this.textBox_Ville.Focus();
        }

    }
}
