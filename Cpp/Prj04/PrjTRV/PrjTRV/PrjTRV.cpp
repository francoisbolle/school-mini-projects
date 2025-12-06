// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "rdv.h"



int _tmain(int argc, _TCHAR* argv[])
{
	// GESTION STATIQUE DE L'OBJET (Cpp uniquement)
	
	/*int inter_int;
	string inter_string;
	rdv inter_rdv;		// instanciation statique de l'objet (CPP uniquement)
	
	system("cls");
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	cout << "\n\t\t==> No du dossier : ";
	cin >> inter_int;
	inter_rdv.set_NoD(inter_int);
	cout << "\n\t\t==> Date du rdv : ";
	cin >> inter_string;
	inter_rdv.set_DatRdv(inter_string);
	cout << "\n\t\t==> Heure du rdv : ";
	cin >> inter_string;
	inter_rdv.set_TimRdv(inter_string);

	cout << "\n\n RECAPITULATIF";
	cout << "\n\t\t==> No du dossier : " << inter_rdv.get_NoD();
	cout << "\n\t\t==> Date du rdv : " << inter_rdv.get_DatRdv();
	cout << "\n\t\t==> Heure du rdv : " << inter_rdv.get_TimRdv();

	cout << "\n";
	system("pause");
	return 0;*/

	// GESTION DYNAMIQUE DE L'OBJET (équivalent CS)
	int inter_int;
	string inter_string;
	rdv *pinter_rdv = 0;		

	pinter_rdv = new rdv();		// instanciation dynamique de l'objet
	system("cls");
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	cout << "\n\t\t==> No du dossier : ";
	cin >> inter_int;
	pinter_rdv->set_NoD(inter_int);
	cout << "\n\t\t==> Date du rdv : ";
	cin >> inter_string;
	pinter_rdv->set_DatRdv(inter_string);
	cout << "\n\t\t==> Heure du rdv : ";
	cin >> inter_string;
	pinter_rdv->set_TimRdv(inter_string);

	cout << "\n\n RECAPITULATIF";
	cout << "\n\t\t==> No du dossier : " << pinter_rdv->get_NoD();
	cout << "\n\t\t==> Date du rdv : " << pinter_rdv->get_DatRdv();
	cout << "\n\t\t==> Heure du rdv : " << pinter_rdv->get_TimRdv();

	delete pinter_rdv;
	pinter_rdv = 0;

	cout << "\n";
	system("pause");
	return 0;
}

