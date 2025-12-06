using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTRV
{
    class avo
    {
        private int PK;
        private string nom;
	    private string datdip;
	    private rdv [] Trdv;	// agrégation du conteneur de type Array

	    public avo(int t_PK)
	    {
		    Array.Resize(ref this.Trdv, 0);	// initialisation de la taille du tableau
            this.PK = t_PK;     // initialisation unique obligatoire à la création
	    }

	    public avo(avo t_avo)		// constructeur par copie avec capture de l'objet initial par pointeur
	    {
            this.PK = t_avo.PK;
            this.nom = t_avo.nom;
		    this.datdip = t_avo.datdip;
		    Array.Resize(ref this.Trdv, t_avo.Trdv.Length);
		    for (int x = 0; x < this.Trdv.Length; x++)
		    {
			    this.Trdv[x] = new rdv(t_avo.Trdv[x]);	// appel du constructeur par copie par défaut de la classe rdv
		    }
	    }

	    public avo(ref avo  r_avo)		// constructeur par copie avec capture de l'objet initial par référence
	    {
            this.PK = r_avo.PK;
            this.nom = r_avo.nom;
		    this.datdip = r_avo.datdip;
            Array.Resize(ref this.Trdv, r_avo.Trdv.Length);
		    for (int x = 0; x < this.Trdv.Length; x++)
		    {
			    this.Trdv[x] = new rdv(r_avo.Trdv[x]);	// appel du constructeur par copie par défaut de la classe rdv
		    }
	    }

	    ~avo()	// destructeur
	    {
            Array.Clear(this.Trdv, 0, this.Trdv.Length);  // libération du tableau de "pointeurs"
            Array.Resize(ref this.Trdv, 0); // élimination des pointeurs du tableau
            GC.Collect();       // appel du Garbage Collector ==> nettoyage des zones mémoires abandonnées
	    }

        public int get_PK()
        {
            return this.PK;
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

	    public void add_rdv(rdv t_rdv)
	    {
		    Array.Resize(ref this.Trdv, this.Trdv.Length + 1);			// redimensionnement du tableau de "pointeurs"
		    this.Trdv[this.Trdv.Length - 1] = new rdv(t_rdv);
	    }

	    void set_rdv(rdv t_rdv, uint indice)
	    {
		    if (indice < this.Trdv.Length) this.Trdv[indice] = t_rdv;
		    else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }

	    //	FAILLE DE SECURISATION
        //rdv get_rdv(uint indice)
        //{
        //    return this.Trdv[indice];
        //}
	    
	    public rdv get_rdv(int indice)
	    {
            if (indice < this.Trdv.Length) return new rdv(this.Trdv[indice]);
            else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }
    }
}
