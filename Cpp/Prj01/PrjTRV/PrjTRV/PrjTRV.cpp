// PrjTRV.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"

void affiche(int t_int = 99);	// surcharge de fonctions avec valeur par défaut
void affiche(int, int t_int2);
void affiche(string);

int _tmain(int argc, _TCHAR* argv[])
{
	int x, y, testI;
	string mess;
	float reel;
	bool testB;
	char testC;
	vector <int> Tint;

	//Tint.resize(0);
	do
	{
		system("cls");
		cout << "\t\tPHASE D'INTRODUCTION";
		cout << "\nValeur de X: ";
		cin >> x;
		cout << "\nValeur de Y: ";
		cin >> y;
		cout << "\nValeur du reel: ";
		cin >> reel;
		cout << "\nCommentaires: ";
		cin >> mess;
		cout << "\n\t\tINTRODUCTION DU TABLEAU D'ENTIERS";

		try
		{
			do
			{
				// VERSION CLASSIQUE
				Tint.resize(Tint.size() + 1);	// redimmensionnement du container ==> +1
				cout << "\n \t\t==> Entier No " << Tint.size() << ": ";
				cin >> Tint[Tint.size() - 1];

				// VERSION PUSHBACK
				/*
				int z;
				cout << "\n \t\t==> Entier No " << Tint.size() + 1 << ": ";
				cin >> z;
				Tint.push_back(z);		// incrémentation de la taille du tableau
				*/
				cout << "\nUn entier sup ? (o/n) ";
				cin >> testC;
			} while (testC == 'o' || testC == 'O');
		}
		catch (...)
		{
			cout << "\n Memoire saturee - Appuyer sur une touche pour cloturer\n";
			system("pause");
		}

		system("cls");
		cout << "\n\n\t\tRECAPITULATIF";
		cout << "\nValeur par defaut d'affiche: ";
		affiche();
		cout << "\nValeur de X: ";
		affiche(x);
		cout << "\nValeur de Y: " << y;
		cout << "\nValeur de X et Y: ";
		affiche(x, y);
		cout << "\nValeur du reel: " << reel;
		cout << "\nCommentaire: ";
		affiche(mess);

		cout << "\n\t\tRECAPITULATIF DU TABLEAU D'ENTIERS";
		for (unsigned int x = 0; x < Tint.size(); x++)	// recouverment de la variable du main
		{
			cout << "\n \t\t==> Entier No " << x + 1 << ": " << Tint[x];
		}
		
		Tint.clear();
		cout << "\n\nRecommencer (0/1) ?";
		cin >> testI;
		testB = (bool) testI;
	} while (testB);

	//cout << "\n";
	//system("pause");
	return 0;
}

void affiche(int t_int)
{
	cout << t_int;
}

void affiche(int t_int1, int t_int2)
{
	cout << t_int1 << " et " << t_int2;
}

void affiche(string t_string)
{
	cout << t_string;
}

