// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//Agrégation non sécurisée : Conteneur simple

#include "stdafx.h"
#include "avo.h"

void intro_rdv(rdv *);
void intro_avos(vector <avo> &);
void intro_avo(avo *);
void recap_Avo(avo &);

int _tmain(int argc, _TCHAR* argv[])
{
	int inter_int, NoAvo;
	string inter_string;
	//char encore;
	rdv inter_rdv;
	vector <avo> Tavo;

	intro_avos(Tavo);
	/*
	Tavo.resize(0);
	do
	{
		Tavo.resize(Tavo.size() + 1);
		
		system("cls");
		cout << "\n \tCOORDONNEES DE L'AVOCAT No " << Tavo.size();
		intro_avo(&Tavo[Tavo.size() - 1]);
		
		//cout << "\n* NOM : ";
		//cin >> inter_string;
		//Tavo[Tavo.size() - 1].set_nom(inter_string);
		//cout << "\n* Date diplome : ";
		//cin >> inter_string;
		//Tavo[Tavo.size() - 1].set_datdip(inter_string);

		//cout << "\n \tGESTION DES RENDEZ-VOUS";
		//cout << "\n\n INTRODUCTION";
		//do
		//{
		//	cout << "\n * RDV no " << Tavo[Tavo.size() - 1].get_TprdvSize() + 1;
		//	intro_rdv(&inter_rdv);

		//	Tavo[Tavo.size() - 1].add_rdv(inter_rdv);
		//	cout << "\n Encore un rdv (O/N) ?";
		//	cin >> encore;
		//} while (encore == 'o' || encore == 'O');
		

		cout << "\n Encore un avocat (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');
*/
	system("cls");
	cout << "\n\n\t\t RECAPITULATIF";
	
	for (unsigned int x = 0; x < Tavo.size(); x++)
	{
		cout << "\n\n*** Avocat No " << x + 1 << " ***";
		recap_Avo(Tavo[x]);
	}

	cout << "\n\n MODFICATION D'UN RDV";
	cout << "\n \tIntroduction du No de l'avocat concerne: ";
	cin >> NoAvo;
	cout << "\n \tIntroduction du No de RDV a modifier: ";
	cin >> inter_int;
	intro_rdv(&inter_rdv);
	Tavo[NoAvo - 1].set_rdv(inter_rdv, inter_int - 1);

	system("cls");
	recap_Avo(Tavo[NoAvo - 1]);
	
	Tavo.clear();
	cout << "\n";
	system("pause");
	return 0;
}

void intro_avo(avo *pavo)
{
	string inter_string;
	char encore;
	rdv inter_rdv;

	cout << "\n* NOM : ";
	cin >> inter_string;
	pavo->set_nom(inter_string);
	cout << "\n* Date diplome : ";
	cin >> inter_string;
	pavo->set_datdip(inter_string);

	cout << "\n \tGESTION DES RENDEZ-VOUS";
	cout << "\n\n INTRODUCTION";
	do
	{
		cout << "\n * RDV no " << pavo->get_TprdvSize() + 1;
		intro_rdv(&inter_rdv);

		pavo->add_rdv(inter_rdv);
		cout << "\n Encore un rdv (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');
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

void intro_avos(vector <avo> &rTavo)
{
	char encore;

	rTavo.resize(0);
	do
	{
		rTavo.resize(rTavo.size() + 1);

		system("cls");
		cout << "\n \tCOORDONNEES DE L'AVOCAT No " << rTavo.size();
		intro_avo(&rTavo[rTavo.size() - 1]);
		cout << "\n Encore un avocat (O/N) ?";
		cin >> encore;
	} while (encore == 'o' || encore == 'O');
}