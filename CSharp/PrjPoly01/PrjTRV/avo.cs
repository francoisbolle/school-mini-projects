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
	    
        private rdv[] TrdvP;	// agrégation du conteneur de type Array

	    public avo()
	    {
		    Array.Resize(ref this.TrdvP, 0);	// initialisation de la taille du tableau
	    }

	    public avo(avo t_avo)		// constructeur par copie avec capture de l'objet initial par pointeur
	    {
		    this.nom = t_avo.nom;
		    this.datdip = t_avo.datdip;
		    Array.Resize(ref this.TrdvP, t_avo.TrdvP.Length);
		    for (int x = 0; x < this.TrdvP.Length; x++)
		    {
                switch (t_avo.TrdvP[x].get_TypRdv())
                {
                    case 0:
                        this.TrdvP[x] = new rdv(t_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;

                    case 1:
                        this.TrdvP[x] = new rdvTrib((rdvTrib) t_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;

                    case 2:
                        this.TrdvP[x] = new rdvPlaid((rdvPlaid) t_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;
                }
		    }
	    }

	    public avo(ref avo  r_avo)		// constructeur par copie avec capture de l'objet initial par référence
	    {
		    this.nom = r_avo.nom;
		    this.datdip = r_avo.datdip;
            Array.Resize(ref this.TrdvP, r_avo.TrdvP.Length);
		    for (int x = 0; x < this.TrdvP.Length; x++)
		    {
                switch(r_avo.TrdvP[x].get_TypRdv())
                {
                    case 0:
                        this.TrdvP[x] = new rdv(r_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;

                    case 1:
                        this.TrdvP[x] = new rdvTrib((rdvTrib) r_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;

                    case 2:
                        this.TrdvP[x] = new rdvPlaid((rdvPlaid) r_avo.TrdvP[x]);	// appel du constructeur par copie par défaut de la classe rdv
                        break;
                }
		    }
	    }

	    ~avo()	// destructeur
	    {
            Array.Clear(this.TrdvP, 0, this.TrdvP.Length);  // libération du tableau de "pointeurs"
            Array.Resize(ref this.TrdvP, 0); // élimination des pointeurs du tableau
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
            return this.TrdvP.Length;
	    }

	    public void add_rdvP(rdv t_rdv)
	    {
		    Array.Resize(ref this.TrdvP, this.TrdvP.Length + 1);			// redimensionnement du tableau de "pointeurs"
            
            string TypRDVdeb = t_rdv.GetType().ToString();
            switch (TypRDVdeb)
            {
                case "PrjTRV.rdv":
                    this.TrdvP[this.TrdvP.Length - 1] = new rdv(t_rdv);	// appel du constructeur par copie par défaut de la classe rdv
                    break;

                case "PrjTRV.rdvTrib":
                    this.TrdvP[this.TrdvP.Length - 1] = new rdvTrib ((rdvTrib) t_rdv);	// appel du constructeur par copie par défaut de la classe rdvTrib
                    break;

                case "PrjTRV.rdvPlaid":
                    this.TrdvP[this.TrdvP.Length - 1] = new rdvPlaid((rdvPlaid) t_rdv);	// appel du constructeur par copie par défaut de la classe rdvPlaid
                    break;
            }
	    }

	    void set_rdvP(rdv t_rdv, uint indice)
	    {
		    if (indice < this.TrdvP.Length)
            {
                switch (t_rdv.get_TypRdv())
                {
                    case 0:
                        this.TrdvP[indice] = new rdv(t_rdv);	// appel du constructeur par copie par défaut de la classe rdv
                        break;

                    case 1:
                        this.TrdvP[indice] = new rdvTrib((rdvTrib)t_rdv);	// appel du constructeur par copie par défaut de la classe rdvTrib
                        break;

                    case 2:
                        this.TrdvP[indice] = new rdvPlaid((rdvPlaid)t_rdv);	// appel du constructeur par copie par défaut de la classe rdvPlaid
                        break;
                }
            }
		    else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }

	    public rdv get_rdvP(int indice)
	    {
            if (indice < this.TrdvP.Length)
            {
                switch (this.TrdvP[indice].get_TypRdv())
                {
                    case 0:
                        return new rdv(this.TrdvP[indice]);	// appel du constructeur par copie par défaut de la classe rdv

                    case 1:
                        return new rdvTrib((rdvTrib) this.TrdvP[indice]);	// appel du constructeur par copie par défaut de la classe rdvTrib

                    default:
                        return new rdvPlaid((rdvPlaid) this.TrdvP[indice]);	// appel du constructeur par copie par défaut de la classe rdvPlaid           
                }
            }
            else throw new IndexOutOfRangeException("Indice hors du tableau");
	    }
    }
}
