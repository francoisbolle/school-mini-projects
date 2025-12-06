using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    public class rdv
    {
        private int TypRdv;     // 0-> simple / 1->Trib / 2->Plaid
        private int NoD;		// contrainte imposée: >0
	    private string DatRdv;
	    protected string TimRdv;

        public rdv()
        {
	        this.NoD = 0;
            this.TypRdv = 0;
        }

        public rdv(int t_NoD)
        {
            this.NoD = t_NoD;
        }

        public rdv(rdv t_rdv)       // Implantation du constructeur par copie OBLIGATOIRE !!!
        {
            this.TypRdv =t_rdv.TypRdv;
            this.NoD = t_rdv.NoD;
            this.DatRdv = t_rdv.DatRdv;
            this.TimRdv = t_rdv.TimRdv;
        }

        public void set_TypRdv(int t_TypRdv)
        {
            if (t_TypRdv >= 0 && t_TypRdv < 3) this.TypRdv = t_TypRdv;
            else throw new Invalid_Value("Valeurs de 0 à 2 uniquement"); 
        }

        public int get_typRdv()
        {
            return this.TypRdv;
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
