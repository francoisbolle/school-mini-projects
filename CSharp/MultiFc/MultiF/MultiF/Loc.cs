using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiF
{
    public class Loc
    {
        private string ville;
        public bool appart;

        public Loc()
        {
            this.appart = true;
        }

        public void set_ville(string t_ville)
        {
            this.ville = t_ville;
        }

        public string  get_ville()
        {
            return this.ville;
        }
    }
}
