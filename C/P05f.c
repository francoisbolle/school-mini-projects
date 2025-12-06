// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>


void main()
{
    int TabInt[10], *pTabInt = 0, x, taille;
    float moy = 0;
    char test;

    pTabInt = TabInt;
    x = 0;

    do
    {
        if(x == 9) printf("\nDernier encodage possible");
        printf(" - Un nouvel encodage (O/N) -");

        /*
        do
        {
            test = getch();
        } while (test != 'n' && test != 'N' && test != 'o' && test != 'O');
        */

        do
        {
            test = getche();
            if(test != 'n' && test != 'N' && test != 'o' && test != 'O')
            {
                printf("\nFrappe non valide - Recommencer : ");
            }
            else break;
        } while (1);

        if(test == 'n' || test == 'N') break;
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

