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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.inter_loc = new Loc();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Intro_Click(object sender, EventArgs e)
        {
            //this.Form_Intro = new Secondaire();   // Variable accessible sur tout le Form ==> designer
            
            Secondaire Form_Intro;                  // Variable locale à l'évènement
            Form_Intro = new Secondaire(this.inter_loc);      // instanciation du Form en mémoire

            DialogResult resu = Form_Intro.ShowDialog();   // Fiche modale 
            if (resu == DialogResult.OK)
            {
                this.textBox_Ville.Text = this.inter_loc.get_ville();
                if (this.inter_loc.appart) this.textBox_TypLoc.Text = "Appartement";
                else this.textBox_TypLoc.Text = "Maison";
            }
        }
    }
}
