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
        printf("\nNombre %d : ", x+1);
        scanf("%d",&TabInt[x]); getchar();
        if(x < 9)
        {
            printf("\nAppuyer sur \"q\" pour interrompre");
            test = getche();
        }
        else printf("\nNombre maximum d'encodages atteint!");
        x++;
        //if(test == 'q' || test == 'Q') break;
    }while(test != 'q' && test != 'Q' && x < 10);    //while(!(test == 'q' || test == 'Q') && x < 10);
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

