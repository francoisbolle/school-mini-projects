// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "rdv.h"


int _tmain(int argc, _TCHAR* argv[])
{

	// GESTION DYNAMIQUE DE L'OBJET (équivalent CS)
	int inter_int;
	string inter_string;
	vector <rdv *> Tprdv;
	char encore;
	
	system("cls");
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	Tprdv.resize(0);
	do
	{
		Tprdv.resize(Tprdv.size() + 1);			// redimensionnement du tableau de pointeurs
		Tprdv[Tprdv.size() - 1] = new rdv();	// allocation dynamique d'une zone rdv pour le dernier pointeur
		cout << "\n * RDV no " << Tprdv.size();
		do
		{
			cout << "\n\t\t==> No du dossier : ";	// a sécuriser si job bien géré
			cin >> inter_int;
		} while (inter_int <= 0);

		Tprdv[Tprdv.size() - 1]->set_NoD(inter_int);
		cout << "\n\t\t==> Date du rdv : ";
		cin >> inter_string;
		Tprdv[Tprdv.size() - 1]->set_DatRdv(inter_string);
		cout << "\n\t\t==> Heure du rdv : ";
		cin >> inter_string;
		Tprdv[Tprdv.size() - 1]->set_TimRdv(inter_string);
		cout << "\n Encore une rdv (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');

	system("cls");
	cout << "\n\n RECAPITULATIF";
	/*for (unsigned int x = 0; x < Tprdv.size(); x++)
	{
		cout << "\n * RDV no " << x + 1;
		cout << "\n\t\t==> No du dossier : " << Tprdv[x]->get_NoD();
		cout << "\n\t\t==> Date du rdv : " << Tprdv[x]->get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << Tprdv[x]->get_TimRdv();
	}*/

	int x = 0;
	for (rdv* pt_rdv : Tprdv)	// boucle de gestion du parcour total du tableau (équivalent for each en C#)
	{
		cout << "\n * RDV no " << ++x;
		cout << "\n\t\t==> No du dossier : " << pt_rdv->get_NoD();
		cout << "\n\t\t==> Date du rdv : " << pt_rdv->get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << pt_rdv->get_TimRdv();
	}

	for (unsigned int x = 0; x < Tprdv.size(); x++)
	{
		delete Tprdv[x];
		Tprdv[x] = 0;
	}

	Tprdv.clear();
	Tprdv.resize(0);

	cout << "\n";
	system("pause");
	return 0;
}

