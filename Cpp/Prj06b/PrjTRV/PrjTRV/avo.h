#pragma once
#include "stdafx.h"
#include "rdv.h"

class avo
{
private:
	string nom;
	string datdip;

public:
	vector <rdv *> Tprdv;	// agrégation non sécurisée sur Tab simple rdv

	avo(void)
	{
		this->Tprdv.resize(0);	// initialisation de la taille du tableau
	}

	avo(avo *p_avo)		// constructeur par copie avec capture de l'objet initial par pointeur
	{
		this->nom = p_avo->nom;
		this->datdip = p_avo->datdip;
		this->Tprdv.resize(p_avo->Tprdv.size());
		for (unsigned int x = 0; x < this->Tprdv.size(); x++)
		{
			// this->Tprdv[x] = new rdv();
			// *this->Tprdv[x] = *p_avo->Tprdv[x];
			this->Tprdv[x] = new rdv(*p_avo->Tprdv[x]);	// appel du constructeur par copie par défaut de la classe rdv
		}
	}

	avo(avo &r_avo)		// constructeur par copie avec capture de l'objet initial par référence
	{
		this->nom = r_avo.nom;
		this->datdip = r_avo.datdip;
		this->Tprdv.resize(r_avo.Tprdv.size());
		for (unsigned int x = 0; x < this->Tprdv.size(); x++)
		{
			// this->Tprdv[x] = new rdv();
			// *this->Tprdv[x] = *r_avo.Tprdv[x];
			this->Tprdv[x] = new rdv(*r_avo.Tprdv[x]);	// appel du constructeur par copie par défaut de la classe rdv
		}
	}

	~avo()	// destructeur
	{
		// libération de chacun des pointeurs
		for (unsigned int x = 0; x < this->Tprdv.size(); x++)
		{
			delete this->Tprdv[x];
			this->Tprdv[x] = 0;
		}
		this->Tprdv.clear();		// libération de la zone mémoire affectée au tableau
	}

	void set_nom(string t_nom)
	{
		this->nom = t_nom;
	}

	string get_nom(void)
	{
		return this->nom;
	}

	void set_datdip(string t_datdip)
	{
		this->datdip = t_datdip;
	}

	string get_datdip(void)
	{
		return this->datdip;
	}
};