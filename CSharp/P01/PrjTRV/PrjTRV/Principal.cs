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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            //this.button_Quit.BackColor = System.Drawing.Color.Red;
            var Button_Temp = (Button)sender;           // variable autotypée
            //Button Button_Temp = (Button)sender;      // variable de type explicite
            switch(Button_Temp.Text)
            {
                case "Valider":
                    Button_Temp.BackColor = System.Drawing.Color.GreenYellow;
                    break;
                default:
                    Button_Temp.BackColor = System.Drawing.Color.Red;
                    break;
            }   
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            //this.button_Quit.BackColor = System.Drawing.SystemColors.Control;
            ((Button)sender).BackColor = System.Drawing.SystemColors.Control;
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.textBox_Nom.Clear();
            this.textBox_Nom.Focus();
            this.textBox_Nom.ReadOnly = false;
            this.textBox_Nom.BackColor = System.Drawing.SystemColors.Control;
        }

        private void button_Val_Click(object sender, EventArgs e)
        {
            this.textBox_Nom.BackColor = Color.GreenYellow;
            this.textBox_Nom.ReadOnly = true;
            this.dataGridView_Nom.Rows.Add(this.textBox_Nom.Text);
        }

        private void textBox_Nom_TextChanged(object sender, EventArgs e)
        {
            this.button_Annuler.Enabled = this.button_Val.Enabled = this.textBox_Nom.Text.Length > 1;
        }
  
    }
}
