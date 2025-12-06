using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    public class rdvPlaid : rdvTrib
    {
	    private bool jury;

	    public rdvPlaid()
	    {
            this.set_TypRdv(2);
            this.jury = false;
	    }

	    public rdvPlaid(string t_ville) : base(t_ville)
	    {
            this.set_TypRdv(2);
	    }

	    public rdvPlaid(string t_ville, int t_NoD) : base(t_ville, t_NoD)
	    {
            this.set_TypRdv(2);
	    }

        public rdvPlaid(rdvPlaid t_rdvPlaid) : base(t_rdvPlaid)
        {
            this.jury = t_rdvPlaid.jury;
        }

	    public void set_jury(bool t_jury)
	    {
		    this.jury = t_jury;
	    }

	    public bool get_jury()
	    {
		    return this.jury;
	    }

        public override void set_Pbool(bool t_bool)
        {
            this.set_jury(t_bool);
        }

        public override bool get_Pbool()
        {
            return this.jury;
        }

    }
}
