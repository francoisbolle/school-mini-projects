using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    class Invalid_Value : Exception
    {
        public string mess;

        public Invalid_Value()
        {
            this.mess = "Valeur Invalide";
        }

        public Invalid_Value(string t_mess)
        {
            this.mess = t_mess;
        }
    }
}
