// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

int intro(int *);
float calcmoy(int * ,int);
void recap(int * ,int, float);

void main()
{
    int TabInt[10], taille;
    float moy;


    taille = intro(TabInt);
    moy = calcmoy(TabInt, taille);
    recap(&TabInt[0], taille, moy);

    getch();
}

int intro(int *pTabInt)
{
    char test;
    int x = 0;

    do
    {
        printf("\nNombre %d : ", x+1);
        scanf("%d",&pTabInt[x]); getchar();
        if(x < 9)
        {
            printf("\nAppuyer sur \"q\" pour interrompre");
            test = getche();
        }
        else printf("\nNombre maximum d'encodages atteint!");
        x++;
        //if(test == 'q' || test == 'Q') break;
    }while(test != 'q' && test != 'Q' && x < 10);    //while(!(test == 'q' || test == 'Q') && x < 10);
    return x;

}

float calcmoy(int *pTabInt, int nbenco)
{
    int x;
    float moy = 0;  // INITIALISATION DE LA ZONE MEMOIRE AVANT EXECUTION DE LA RECURRENCE

    for(x = 0; x < nbenco; x++)
    {
        moy += (float) *pTabInt/nbenco;
        //moy += *pTabInt;
        pTabInt++;   // on vise l'entier suivant dans le tableau
    }
    //if(nbenco) moy /= (float) nbenco;
    return moy;
}


void recap(int *pTabInt ,int nbenco, float moyenne)
{
    int x;

    for (x = 0; x < nbenco; x++)
    {
        //printf("\nNombre %d : %d", x + 1, *pTabInt++);
        printf("\nNombre %d : %d", x + 1, pTabInt[x]);
        //pTabInt++;   // on vise l'entier suivant dans le tableau
    }

    printf("\n ==> La moyenne des %d nombre(s) encode(s) vaut : %.2f", nbenco, moyenne);
}