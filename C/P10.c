// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>

int introtab(int **ppTab, int *ptaille);
//float calcmoy(int *pTint, int nbenco);
int calcmoy(int *pTint, int nbenco, float *pmoy);
void libere(int **ppLib, int *ptaille);

int main(void)
{
    int *pTab;
    int taille, x;
    float moy;


    printf("\n\t\t INTRODUCTION DES RESULTATS DU TEST");

    if(introtab(&pTab, &taille))
    {
        printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
        getch();
    }

    //moy = calcmoy(pTab, taille);
    if(!calcmoy(pTab, taille, &moy))
    {
        printf("\n Calcul moyenne impossible sur tableau vide ! - Appyer sur une touche pour valider");
        getch();
    }

    printf("\n\t\t RECAPITULATIF DES RESULTATS DU TEST");
    for(x = 0; x < taille; x++)
    {
        printf("\n\t * Resultat copie No %d : %d", x+1, pTab[x]);
    }

    if(taille) printf("\n\n ==> Moyenne du groupe : %.2f", moy);

    libere(&pTab, &taille);

    getch();
    return 0;
}

int introtab(int **ppTab, int *ptaille)
{
    int *pMem = 0;
    char test;

    *ppTab = 0;
    *ptaille = 0;
    do
    {
        (*ptaille)++;
        pMem = *ppTab;
        *ppTab = (int *) realloc(*ppTab ,*ptaille * sizeof (int));   // demande d'allocation mémoire
        if(!*ppTab)
        {
            *ppTab = pMem;
            (*ptaille)--;

            pMem = 0;
            return 1;
        }
        pMem = 0;
        printf("\n\t ==> Resultat copie No %d : ", *ptaille);
        scanf("%d", &(*ppTab)[*ptaille - 1]); getchar();
        printf("\n Une autre copie? (o/n) : ");
        test = getche();
    }while(test == 'o' || test == 'O');

    return 0;
}
/*
float calcmoy(int *pTint, int nbenco)
{
    int x;
    float moy;

    if(!nbenco)
    {
        printf("\n Calcul moyenne impossible sur tableau vide ! - Appyer sur une touche pour valider");
        getch();
        return 0;
    }

    for(x = 0, moy = 0; x < nbenco; x++)
    {
        moy += (float) pTint[x] / nbenco;
    }

    return moy;
}
*/


int calcmoy(int *pTint, int nbenco, float *pmoy)
{
    int x;
    float moy;

    if(!nbenco) return 0;   // renvoi du code erreur

    for(x = 0, moy = 0; x < nbenco; x++)
    {
        moy += (float) pTint[x] / nbenco;
    }
    *pmoy = moy;
    return 1;   // renvoi code OK
}

void libere(int **ppLib, int *ptaille)
{
    free(*ppLib); // libération de la ressource mémoire allouée
    *ppLib = 0;
    *ptaille = 0;
}