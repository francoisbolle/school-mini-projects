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
		    this.jury = false;
	    }

	    public rdvPlaid(string t_ville) : base(t_ville)
	    {

	    }

	    public rdvPlaid(string t_ville, int t_NoD) : base(t_ville, t_NoD)
	    {

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

    }
}
