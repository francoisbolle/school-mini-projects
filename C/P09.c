// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>









int main(void)
{
    int *pTab = 0, *pMem = 0;
    int taille = 0, x;
    float moy;
    char test;

    printf("\n\t\t INTRODUCTION DES RESULTATS DU TEST");
    do
    {
        taille++;
        pMem = pTab;
        pTab = (int *) realloc(pTab ,taille * sizeof (int));   // demande d'allocation mémoire
        if(!pTab)
        {
            pTab = pMem;
            taille--;
            printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
            getch();
            break;
        }
        printf("\n\t ==> Resultat copie No %d : ", taille);
        scanf("%d", &pTab[taille - 1]); getchar();
        printf("\n Une autre copie? (o/n) : ");
        test = getche();
    }while(test == 'o' || test == 'O');

    printf("\n\t\t RECAPITULATIF DES RESULTATS DU TEST");
    for(x = 0, moy = 0; x < taille; x++)
    {
        printf("\n\t * Resultat copie No %d : %d", x+1, pTab[x]);
        moy += (float) pTab[x] / taille;
    }

    if(taille) printf("\n\n ==> Moyenne du groupe : %.2f", moy);
    free(pTab); // libération de la ressource mémoire allouée
    pTab = pMem = 0;

    getch();
    return 0;
}

