// PrjHeri.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "rdvTrib.h"

int _tmain(int argc, _TCHAR* argv[])
{
	//rdv rdvT;
	//rdv rdvT(5); 
	//rdvTrib rdvT;
	//rdvTrib rdvT("Arlon");
	rdvTrib rdvT("Arlon", 7);
	

	int inter_int;
	string inter_string;

	system("cls");
	cout << "\nEncodage du rdv";
	cout << "\n\t==> No dossier : ";
	cin >> inter_int;
	rdvT.set_NoD(inter_int);

	cout << "\n\t==> Date : ";
	cin >> inter_string;
	rdvT.set_DatRdv(inter_string);

	cout << "\n\t==> Heure : ";
	cin >> inter_string;
	rdvT.set_TimRdv(inter_string);

	// Ville - Juge

	cout << "\nRecapitulatif du rdvT";
	cout << "\n\t==> No dossier : " << rdvT.get_NoD();
	cout << "\n\t==> Date : " << rdvT.get_DatRdv();
	cout << "\n\t==> Heure : " << rdvT.get_TimRdv();
	// Ville - Juge

	cout << "\n";
	system("pause");
	return 0;
}

