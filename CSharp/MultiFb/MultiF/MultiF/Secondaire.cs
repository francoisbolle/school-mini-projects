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
        public Secondaire(Principal t_principal)
        {
            InitializeComponent();
            this.FPrincipal_Persist = t_principal;
        }

        private void button_Val_Click(object sender, EventArgs e)
        {
           
            this.FPrincipal_Persist.inter_loc.set_ville(this.textBox_Ville.Text);
            this.FPrincipal_Persist.inter_loc.appart = this.checkBox_Appart.Checked;

            this.FPrincipal_Persist.textBox_Ville.Text = this.FPrincipal_Persist.inter_loc.get_ville();
            if (this.FPrincipal_Persist.inter_loc.appart) this.FPrincipal_Persist.textBox_TypLoc.Text = "Appartement";
            else this.FPrincipal_Persist.textBox_TypLoc.Text = "Maison";

            this.button_Cancel_Click(sender, e);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.checkBox_Appart.Checked = false;
            this.textBox_Ville.Clear();
            this.textBox_Ville.Focus();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
