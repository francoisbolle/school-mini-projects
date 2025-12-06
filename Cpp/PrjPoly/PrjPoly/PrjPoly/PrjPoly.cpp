// PrjPoly.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "rdvPlaid.h"

int _tmain(int argc, _TCHAR* argv[])
{
	rdv *prdv = 0;

	int inter_int, typrdv;
	string inter_string;

	system("cls");
	cout << "\n Introduction du type de rdv desire (0->Simple / 1->Tribunal / 2->Plaidoirie): ";
	cin >> typrdv;

	switch(typrdv)
	{
		case 0:
			prdv = new rdv();
			break;

		case 1:
			prdv = new rdvTrib();
			break;

		case 2:
			prdv = new rdvPlaid();
			break;
		
		default:
			return 0;
	}

	cout << "\nEncodage du rdv";
	cout << "\n\t==> No dossier : ";
	cin >> inter_int;
	prdv->set_NoD(inter_int);

	cout << "\n\t==> Date : ";
	cin >> inter_string;
	prdv->set_DatRdv(inter_string);

	cout << "\n\t==> Heure : ";
	cin >> inter_string;
	prdv->set_TimRdv(inter_string);

	if (prdv->get_typRdv() == "rdvTrib" || prdv->get_typRdv() == "rdvPlaid")
	{
		// Ville - Juge
		cout << "\n\t==> Ville : ";
		cin >> inter_string;
		prdv->setP_string(inter_string, true);

		cout << "\n\t==> Juge : ";
		cin >> inter_string;
		prdv->setP_string(inter_string, false);

		if (prdv->get_typRdv() == "rdvPlaid")
		{
			// Jury
			cout << "\n\t==> Jury (o/n) : ";
			cin >> inter_string;
			prdv->setP_bool(inter_string == "o" || inter_string == "O");
		}
	}


	cout << "\nRecapitulatif du rdv";
	cout << "\n\t==> No dossier : " << prdv->get_NoD();
	cout << "\n\t==> Date : " << prdv->get_DatRdv();
	cout << "\n\t==> Heure : " << prdv->get_TimRdv();

	if (prdv->get_typRdv() == "rdvTrib" || prdv->get_typRdv() == "rdvPlaid")
	{
		// Ville - Juge
		cout << "\n\t==> Ville : " << prdv->getP_string(true);
		cout << "\n\t==> Juge : " << prdv->getP_string(false);

		// Jury
		if (prdv->get_typRdv() == "rdvPlaid") cout << "\n\t==> Jury : " << prdv->getP_bool();
	}

	delete prdv;
	prdv = 0;

	cout << "\n";
	system("pause");
	return 0;
}

