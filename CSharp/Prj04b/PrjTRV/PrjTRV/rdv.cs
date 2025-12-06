using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    class rdv
    {
        private int AvFK;
        private int NoD;		// contrainte imposée: >0
	    private string DatRdv;
	    private string TimRdv;

        public rdv(int t_AvFk)
        {
	        this.NoD = 0;
            this.AvFK = t_AvFk; // initialisation unique imposée à la construction de l'objet
        }

        public rdv(rdv t_rdv)       // Implantation du constructeur par copie OBLIGATOIRE !!!
        {
            this.AvFK = t_rdv.AvFK;
            this.NoD = t_rdv.NoD;
            this.DatRdv = t_rdv.DatRdv;
            this.TimRdv = t_rdv.TimRdv;
        }

        public int get_AvFk()
        {
            return this.AvFK;
        }

        public void set_NoD(string t_NoD)
        {
            this.set_NoD(Convert.ToInt16(t_NoD));
        }

        public void set_NoD(int t_NoD)
        {
	        if (t_NoD > 0) this.NoD = t_NoD;
	        //else throw new Invalid_Value();	// levée d'exception
	        else throw new Invalid_Value("Valeurs positives uniquement");	// levée d'exception
        }

        public int get_NoD()
        {
	        return this.NoD;
        }

        public void set_DatRdv(string t_DatRdv)
        {
	        this.DatRdv = t_DatRdv;
        }

        public string get_DatRdv()
        {
	        return this.DatRdv;
        }

        public void set_TimRdv(string t_TimRdv)
        {
	        this.TimRdv = t_TimRdv;
        }

        public string get_TimRdv()
        {
	        return this.TimRdv;
        }

    }
}
