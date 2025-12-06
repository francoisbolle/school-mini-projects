using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    public class avo
    {
        private string nom;
	    private string datdip;
	    private rdv [] Trdv;	// agrégation du conteneur de type Array
        //private rdvCli[] TrdvCli;
        private rdvTrib [] TrdvTrib;
        private rdvPlaid[] TrdvPlaid;

	    public avo()
	    {
            Array.Resize(ref this.Trdv, 0);
            Array.Resize(ref this.TrdvTrib, 0);
		    Array.Resize(ref this.TrdvPlaid, 0);	// initialisation de la taille du tableau
	    }

	    public avo(avo t_avo)		// constructeur par copie avec capture de l'objet initial par pointeur
	    {
		    this.nom = t_avo.nom;
		    this.datdip = t_avo.datdip;

            Array.Resize(ref this.Trdv, t_avo.Trdv.Length);
            for (int x = 0; x < this.Trdv.Length; x++ )
            {
                this.Trdv[x] = new rdv(t_avo.Trdv[x]);
            }
            Array.Resize(ref this.TrdvTrib, t_avo.TrdvTrib.Length);
            for (int x = 0; x < this.TrdvTrib.Length; x++)
            {
                this.Trdv[x] = new rdvTrib(t_avo.TrdvTrib[x]);
            }
            Array.Resize(ref this.TrdvPlaid, t_avo.TrdvPlaid.Length);
		    for (int x = 0; x < this.TrdvPlaid.Length; x++)
		    {
			    this.TrdvPlaid[x] = new rdvPlaid(t_avo.TrdvPlaid[x]);	// appel du constructeur par copie par défaut de la classe rdv
		    }
	    }

	    public avo(ref avo  r_avo)		// constructeur par copie avec capture de l'objet initial par référence
	    {
		    this.nom = r_avo.nom;
		    this.datdip = r_avo.datdip;
            Array.Resize(ref this.TrdvPlaid, r_avo.TrdvPlaid.Length);
		    for (int x = 0; x < this.TrdvPlaid.Length; x++)
		    {
			    this.TrdvPlaid[x] = new rdvPlaid(r_avo.TrdvPlaid[x]);	// appel du constructeur par copie par défaut de la classe rdv
		    }
	    }

	    ~avo()	// destructeur
	    {
            Array.Clear(this.Trdv, 0, this.Trdv.Length);
            Array.Clear(this.TrdvTrib, 0, this.TrdvTrib.Length);
            Array.Clear(this.TrdvPlaid, 0, this.TrdvPlaid.Length);  // libération du tableau de "pointeurs"
            Array.Resize(ref this.Trdv, 0);
            Array.Resize(ref this.TrdvTrib, 0);
            Array.Resize(ref this.TrdvPlaid, 0); // élimination des pointeurs du tableau
            GC.Collect();       // appel du Garbage Collector ==> nettoyage des zones mémoires abandonnées
	    }

	    public void set_nom(string t_nom)
	    {
		    this.nom = t_nom;
	    }

	    public string get_nom()
	    {
		    return this.nom;
	    }

	    public void set_datdip(string t_datdip)
	    {
		    this.datdip = t_datdip;
	    }

	    public string get_datdip()
	    {
		    return this.datdip;
	    }

        public int get_TrdvSize()
        {
            return this.Trdv.Length;
        }

        public int get_TrdvTribSize()
        {
            return this.TrdvTrib.Length;
        }

	    public int get_TrdvPlaidSize()
	    {
            return this.TrdvPlaid.Length;
	    }

        public void add_rdv(rdv t_rdv)
        {
            Array.Resize(ref this.Trdv, this.Trdv.Length + 1);			// redimensionnement du tableau de "pointeurs"
            this.Trdv[this.Trdv.Length - 1] = new rdv(t_rdv);
        }

        public void add_rdvTrib(rdvTrib t_rdvTrib)
        {
            Array.Resize(ref this.TrdvTrib, this.TrdvTrib.Length + 1);			// redimensionnement du tableau de "pointeurs"
            this.TrdvTrib[this.TrdvTrib.Length - 1] = new rdvTrib(t_rdvTrib);
        }

	    public void add_rdvPlaid(rdvPlaid t_rdvPlaid)
	    {
		    Array.Resize(ref this.TrdvPlaid, this.TrdvPlaid.Length + 1);			// redimensionnement du tableau de "pointeurs"
		    this.TrdvPlaid[this.TrdvPlaid.Length - 1] = new rdvPlaid(t_rdvPlaid);
	    }

        void set_rdv(rdv t_rdv, uint indice)
        {
            if (indice < this.Trdv.Length) this.Trdv[indice] = t_rdv;
            else throw new IndexOutOfRangeException("Indice hors du tableau");
        }

        void set_rdvTrib(rdvTrib t_rdvTrib, uint indice)
        {
            if (indice < this.TrdvTrib.Length) this.TrdvTrib[indice] = t_rdvTrib;
            else throw new IndexOutOfRangeException("Indice hors du tableau");
        }

	    void set_rdvPlaid(rdvPlaid t_rdvPlaid, uint indice)
	    {
		    if (indice < this.TrdvPlaid.Length) this.TrdvPlaid[indice] = t_rdvPlaid;
		    else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }

        public rdv get_rdv(int indice)
        {
            if (indice < this.Trdv.Length) return new rdv(this.Trdv[indice]);
            else throw new IndexOutOfRangeException("Indice hors du tableau");
        }

        public rdvTrib get_rdvTrib(int indice)
        {
            if (indice < this.TrdvTrib.Length) return new rdvTrib(this.TrdvTrib[indice]);
            else throw new IndexOutOfRangeException("Indice hors du tableau");
        }

	    public rdvPlaid get_rdvPlaid(int indice)
	    {
            if (indice < this.TrdvPlaid.Length) return new rdvPlaid(this.TrdvPlaid[indice]);
            else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }
    }
}
