using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    public class rdvTrib : rdv
    {
	    private string ville;
	    private string juge;
        
        private void ini()
        {
            this.set_DatRdv("0");	// Accès direct impossible à la variable privée
            this.TimRdv = "0";		// Accès direct à la variable protégée
            this.ville = "-";
            this.juge = "-";
        }


	    public rdvTrib()
	    {
            ini();
	    }

	    public rdvTrib(string t_ville, int t_NoD = 3) : base(t_NoD)
	    {
            ini();
		    this.ville = t_ville;
	    }

        public rdvTrib(rdvTrib t_rdvTrib) : base(t_rdvTrib)
        {
            this.ville = t_rdvTrib.ville;
            this.juge = t_rdvTrib.juge;
        }

	    public void set_ville(string t_ville)
	    {
		    this.ville = t_ville;
	    }

	    public string get_ville()
	    {
		    return this.ville;
	    }

	    public void set_juge(string t_juge)
	    {
		    this.juge = t_juge;
	    }

	    public string get_juge()
	    {
		    return this.juge;
	    }


    }
}
