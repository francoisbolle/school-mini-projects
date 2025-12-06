// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//Agrégation non sécurisée : Conteneur simple

#include "stdafx.h"
#include "avo.h"

void intro_rdv(rdv *);
void recap_Avo(avo &);

int _tmain(int argc, _TCHAR* argv[])
{
	int inter_int;
	string inter_string;
	rdv inter_rdv;

	avo *pinter_avo = 0;
	char encore;

	pinter_avo = new avo();
	
	system("cls");
	cout << "\n \tCOORDONNEES DE L'AVOCAT";
	cout << "\n* NOM : ";
	cin >> inter_string;
	pinter_avo->set_nom(inter_string);
	cout << "\n* Date diplome : ";
	cin >> inter_string;
	pinter_avo->set_datdip(inter_string);
	
	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	
	do
	{
		cout << "\n * RDV no " << pinter_avo->get_TprdvSize() + 1;
		intro_rdv(&inter_rdv);
		
		pinter_avo->add_rdv(inter_rdv);
		cout << "\n Encore une rdv (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');

	system("cls");
	recap_Avo(*pinter_avo);

	cout << "\n\n MODFICATION D'UN RDV";
	cout << "\n \tIntroduction du No de RDV a modifier: ";
	cin >> inter_int;
	intro_rdv(&inter_rdv);
	pinter_avo->set_rdv(inter_rdv, inter_int - 1);

	system("cls");
	recap_Avo(*pinter_avo);


	
	//avo testcopie = *pinter_avo;		// appel du constructeur par copie par référence
	delete pinter_avo;
	pinter_avo = 0;
	/*
	cout << "\n\n --- AFFICHAGE TESTCOPIE";
	for (unsigned int x = 0; x < testcopie.Tprdv.size(); x++)
	{
		cout << "\n * RDV no " << x + 1;
		cout << "\n\t\t==> No du dossier : " << testcopie.Tprdv[x]->get_NoD();
		cout << "\n\t\t==> Date du rdv : " << testcopie.Tprdv[x]->get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << testcopie.Tprdv[x]->get_TimRdv();
	}

	avo *ptestcopie = new avo(&testcopie);		// appel du constructeur par copie via pointeur
	cout << "\n\n --- AFFICHAGE pTESTCOPIE";
	for (unsigned int x = 0; x < ptestcopie->Tprdv.size(); x++)
	{
		cout << "\n * RDV no " << x + 1;
		cout << "\n\t\t==> No du dossier : " << ptestcopie->Tprdv[x]->get_NoD();
		cout << "\n\t\t==> Date du rdv : " << ptestcopie->Tprdv[x]->get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << ptestcopie->Tprdv[x]->get_TimRdv();
	}
	
	delete ptestcopie;
	ptestcopie = 0;
	*/

	cout << "\n";
	system("pause");
	return 0;
}

void intro_rdv(rdv *prdv)
{
int inter_int;
string inter_string;
	do
	{
		cout << "\n\t\t==> No du dossier : ";	// a sécuriser si job bien géré
		cin >> inter_int;
	} while (inter_int <= 0);

	prdv->set_NoD(inter_int);
	cout << "\n\t\t==> Date du rdv : ";
	cin >> inter_string;
	prdv->set_DatRdv(inter_string);
	cout << "\n\t\t==> Heure du rdv : ";
	cin >> inter_string;
	prdv->set_TimRdv(inter_string);
}


void recap_Avo(avo &r_avo)
{
	cout << "\n\n RECAPITULATIF";
	cout << "\n \tCOORDONNEES DE L'AVOCAT";
	cout << "\n* NOM : " << r_avo.get_nom();
	cout << "\n* Date diplome : " << r_avo.get_datdip();

	for (unsigned int x = 0; x < r_avo.get_TprdvSize(); x++)
	{
		cout << "\n * RDV No " << x + 1;
		cout << "\n\t\t==> No du dossier : " << r_avo.get_rdv(x)->get_NoD();
		cout << "\n\t\t==> Date du rdv : " << r_avo.get_rdv(x)->get_DatRdv();
		cout << "\n\t\t==> Heure du rdv : " << r_avo.get_rdv(x)->get_TimRdv();
	}
}