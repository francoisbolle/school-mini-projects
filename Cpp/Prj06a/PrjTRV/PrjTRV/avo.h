#pragma once
#include "stdafx.h"
#include "rdv.h"

class avo
{
private:
	string nom;
	string datdip;

public:
	vector <rdv> Trdv;	// agrégation non sécurisée sur Tab simple rdv

	avo(void)
	{
		this->Trdv.resize(0);	// initialisation de la taille du tableau
	}

	~avo()	// destructeur
	{
		this->Trdv.clear();		// libération de la zone mémoire affectée au tableau
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