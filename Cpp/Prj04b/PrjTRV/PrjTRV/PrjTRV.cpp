// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "rdv.h"


int _tmain(int argc, _TCHAR* argv[])
{

	// GESTION DYNAMIQUE DE L'OBJET (équivalent CS)
	int inter_int;
	string inter_string;
	rdv *pinter_rdv = 0;		

	try
	{
		pinter_rdv = new rdv();		// instanciation dynamique de l'objet
		system("cls");
		cout << "\n \tGESTION DES RENDEZ-VOUS";
		cout << "\n\n INTRODUCTION";
		cout << "\n\t\t==> No du dossier : ";	// a sécuriser si job bien géré
		cin >> inter_int;
		pinter_rdv->set_NoD(inter_int);
		cout << "\n\t\t==> Date du rdv : ";
		cin >> inter_string;
		pinter_rdv->set_DatRdv(inter_string);
		cout << "\n\t\t==> Heure du rdv : ";
		cin >> inter_string;
		pinter_rdv->set_TimRdv(inter_string);
	}
	/*catch (Invalid_Value)
	{
		cout << "\n Pas de valeurs negatives sur NoD";
	}*/

	catch (Invalid_Value Exc)				// capture "torpille" Invalid_Value
	{
		cout << "\n Erreur d'encodage : " << Exc.Mess;
	}

	catch (...)								// capture autre "torpilles"
	{
		cout << "\n Memoire saturee - Appuyer sur une touche pour cloturer\n";
		system("pause");
	}


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

