// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"

struct rdv
{
	int NoD;
	string DatRdv;
	string TimRdv;
};

void intro_rdv(vector <rdv> *pT_rdv);
void intro_rdv(vector <rdv> &rT_rdv);

void recap_rdv(rdv *p_rdv);
void recap_rdv(rdv t_rdv);
void lib_rdv(vector <rdv> *pT_rdv, unsigned int indice);	// suppression du rdv à l'indice donné
void lib_rdv(vector <rdv> *pT_rdv);	// suppression du tableau de rdv
void lib_rdv(vector <rdv> &rT_rdv);

int _tmain(int argc, _TCHAR* argv[])
{
	vector <rdv> Trdv;

	system("cls");
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	intro_rdv(&Trdv);
	intro_rdv(Trdv);
	cout << "\n\n RECAPITULATIF";
	for (unsigned int x = 0; x < Trdv.size(); x++)
	{
		cout << "\n\t* RDV No " << x + 1;
		recap_rdv(&Trdv[x]);
		recap_rdv(Trdv[x]);
	}

	lib_rdv(&Trdv, 1);	// libération du 2ème élément (s'il existe)
	lib_rdv(&Trdv);		// libération de tout le tableau de rdv
	lib_rdv(Trdv);		// idem par référence

	cout << "\n";
	system("pause");
	return 0;
}

void intro_rdv(vector <rdv> *pT_rdv)
{
	char test;

	do
	{
		pT_rdv->resize(pT_rdv->size() + 1);
		cout << "\n\t * RDV No " << pT_rdv->size();
		cout << "\n\t\t==> No du dossier : ";
		cin >> (*pT_rdv)[pT_rdv->size() - 1].NoD;
		cout << "\n\t\t==> Date du rdv : ";
		cin >> (*pT_rdv)[pT_rdv->size() - 1].DatRdv;
		cout << "\n\t\t==> Heure du rdv : ";
		cin >> (*pT_rdv)[pT_rdv->size() - 1].TimRdv;

		cout << "\nUn rdv supp? (o/n) ";
		cin >> test;
	} while (test =='o' || test == 'O');
}

void intro_rdv(vector <rdv> &rT_rdv)
{
	char test;

	do
	{
		rT_rdv.resize(rT_rdv.size() + 1);
		cout << "\n\t * RDV No " << rT_rdv.size();
		cout << "\n\t\t==> No du dossier : ";
		cin >> rT_rdv[rT_rdv.size() - 1].NoD;
		cout << "\n\t\t==> Date du rdv : ";
		cin >> rT_rdv[rT_rdv.size() - 1].DatRdv;
		cout << "\n\t\t==> Heure du rdv : ";
		cin >> rT_rdv[rT_rdv.size() - 1].TimRdv;

		cout << "\nUn rdv supp? (o/n) ";
		cin >> test;
	} while (test == 'o' || test == 'O');
}

void recap_rdv(rdv *p_rdv)
{
	cout << "\n\t\t==> No du dossier : " << p_rdv->NoD;
	cout << "\n\t\t==> Date du rdv : " << p_rdv->DatRdv;
	cout << "\n\t\t==> Heure du rdv : " << p_rdv->TimRdv;
}

void recap_rdv(rdv t_rdv)
{
	cout << "\n\t\t==> No du dossier : " << t_rdv.NoD;
	cout << "\n\t\t==> Date du rdv : " << t_rdv.DatRdv;
	cout << "\n\t\t==> Heure du rdv : " << t_rdv.TimRdv;
}

void lib_rdv(vector <rdv> *pT_rdv, unsigned int indice)
{
	if (indice < pT_rdv->size())
	{
		auto rdv_todel = pT_rdv->begin() + indice;
		pT_rdv->erase(rdv_todel);
	}
}

void lib_rdv(vector <rdv> *pT_rdv)
{
	pT_rdv->clear();
}

void lib_rdv(vector <rdv> &rT_rdv)
{
	rT_rdv.clear();
}



// RECAPITULATIF DES TRANSFERTS D'ARGUMENTS ENTRE FONCTIONS

//void intro(rdv *p_rdv);		// par pointeur
//void intro(rdv &r_rdv);		// par référence
///*void intro(rdv t_rdv);*/	//par copie
//
//
//int _tmain(int argc, _TCHAR* argv[])
//{
//	rdv y;
//	
//	intro(&y);
//	intro(y);
//}
//
//void intro(rdv *p_rdv)
//{
//	cin >> p_rdv->NoD;
//}
//
//void intro(rdv &r_rdv)
//{
//	cin >> r_rdv.NoD;
//}
//
///*void intro(rdv t_rdv)
//{
//	cin >> t_rdv.NoD;
//}*/