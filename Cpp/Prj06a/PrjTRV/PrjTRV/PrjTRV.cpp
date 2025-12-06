// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//Agrégation non sécurisée : Conteneur simple

#include "stdafx.h"
#include "avo.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int inter_int;
	string inter_string;

	avo inter_avo;
	char encore;
	
	system("cls");
	cout << "\n \tCOORDONNEES DE L'AVOCAT";
	cout << "\n* NOM : ";
	cin >> inter_string;
	inter_avo.set_nom(inter_string);
	cout << "\n* Date diplome : ";
	cin >> inter_string;
	inter_avo.set_datdip(inter_string);
	
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	
	do
	{
		
		inter_avo.Trdv.resize(inter_avo.Trdv.size() + 1);			// redimensionnement du tableau de pointeurs
		cout << "\n * RDV no " << inter_avo.Trdv.size();
		do
		{
			cout << "\n\t\t==> No du dossier : ";	// a sécuriser si job bien géré
			cin >> inter_int;
		} while (inter_int <= 0);

		inter_avo.Trdv[inter_avo.Trdv.size() - 1].set_NoD(inter_int);
		cout << "\n\t\t==> Date du rdv : ";
		cin >> inter_string;
		inter_avo.Trdv[inter_avo.Trdv.size() - 1].set_DatRdv(inter_string);
		cout << "\n\t\t==> Heure du rdv : ";
		cin >> inter_string;
		inter_avo.Trdv[inter_avo.Trdv.size() - 1].set_TimRdv(inter_string);
		cout << "\n Encore une rdv (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');

	system("cls");
	cout << "\n\n RECAPITULATIF";
	cout << "\n \tCOORDONNEES DE L'AVOCAT";
	cout << "\n* NOM : " << inter_avo.get_nom();
	cout << "\n* Date diplome : " << inter_avo.get_datdip();

	for (unsigned int x = 0; x <= inter_avo.Trdv.size(); x++)
	{
		cout << "\n * RDV no " << x + 1;
		cout << "\n\t\t==> No du dossier : " << inter_avo.Trdv[x].get_NoD();
		cout << "\n\t\t==> Date du rdv : " << inter_avo.Trdv[x].get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << inter_avo.Trdv[x].get_TimRdv();
	}

	cout << "\n";
	system("pause");
	return 0;
}

