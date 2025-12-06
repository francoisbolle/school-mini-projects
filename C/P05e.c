// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>


void main()
{
    int TabInt[10], *pTabInt = 0, x, taille, Fstop = 0, Fencore = 0;
    float moy = 0;
    char test;

    pTabInt = TabInt;
    x = 0;

    do
    {
        if(x == 9) printf("\nDernier encodage possible");
        printf(" - Un nouvel encodage (O/N) -");
        do
        {
            test = getch();
            Fencore = 0;
            switch (test)
            {
                case 'o':
                case 'O':
                    Fstop = 0;
                    break;
                case 'n':
                case 'N':
                    Fstop = 1;
                    break;
                default:
                    Fencore = 1;
                    break;
            }
        } while (Fencore);

        if(Fstop) break;
        printf("\nNombre %d : ", x+1);
        scanf("%d",&TabInt[x]); getchar();
        x++;
    }while(x < 10);
    taille = x;

    for(x = 0; x < taille; x++)
    {
        printf("\nNombre %d : %d", x+1, *pTabInt);
        moy += (float) *pTabInt/taille;    //moy = moy + *pTabInt/taille;
        pTabInt++;   // on vise l'entier suivant dans le tableau
    }

    printf("\n ==> La moyenne des %d nombre(s) encode(s) vaut : %.2f", taille, moy);
    pTabInt = 0;    // sécurisation du pointeur fou en sortie de boucle

    getch();
}

