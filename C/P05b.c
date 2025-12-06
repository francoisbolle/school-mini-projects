// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>


void main()
{
    int TabInt[10], *pTabInt = 0, x;


    pTabInt = &TabInt[0];    // pTabInt = TabInt;
    // intro + récap du tableau via gestion pointeur ==> enco > OFFSET / recap > incrémentation pTabInt

    for(x = 0; x < 10; x++)
    {
        printf("\nNombre %d : ", x+1);
        // scanf("%d",&TabInt[x]); getchar();
        //scanf("%d",&pTabInt[x]); getchar();
        //scanf("%d",pTabInt + x); getchar();
        scanf("%d",&*(pTabInt + x)); getchar();
    }

    for(x = 0; x < 10; x++ /*, pTabInt++ */)
    {
        //printf("\nNombre : %d", TabInt[x]);
        //printf("\nNombre %d : %d", x+1, *pTabInt);
        printf("\nNombre %d : %d", x+1, *pTabInt++);
        // ATTENTION UTILISATION DU POINTEUR FOU EN SORTIE BOUCLE =>printf("\nNombre %d : %d", x+1, *++pTabInt);
        //pTabInt++;   // on vise l'entier suivant dans le tableau
    }
    pTabInt = 0;    // sécurisation du pointeur fou en sortie de boucle

    getch();
}

