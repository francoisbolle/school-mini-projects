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
        public Secondaire(Loc t_Loc)
        {
            InitializeComponent();
            this.Loc_Persist = t_Loc;
        }

        private void button_Val_Click(object sender, EventArgs e)
        {
            this.Loc_Persist.set_ville(this.textBox_Ville.Text);
            this.Loc_Persist.appart = this.checkBox_Appart.Checked;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
