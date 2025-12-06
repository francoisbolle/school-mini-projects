// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>

typedef struct
{
    int *pTabRes;
    int taille;
    float moy;
}TestClas;


int main(void)
{
    // VARIABLE STRUCTUREE STATIQUE
    /*
    TestClas EncoRes;
    int x,*pMem = 0;
    char test;

    printf("\n\t ENCODAGE DES RESULTATS");

    EncoRes.taille = 0;
    EncoRes.pTabRes = 0;
    EncoRes.moy = 0;
    do
    {
        EncoRes.taille++;
        pMem = EncoRes.pTabRes;
        EncoRes.pTabRes = (int *) realloc(EncoRes.pTabRes, EncoRes.taille * sizeof (int));
        if(!EncoRes.pTabRes)
        {
            EncoRes.pTabRes = pMem;
            EncoRes.taille--;
            printf("\n Memoire saturee - Appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        printf("\n\t==> Resultat No %d : ", EncoRes.taille);
        scanf("%d", &EncoRes.pTabRes[EncoRes.taille-1]); getchar();
        printf("\n Encore une encodage? (o/n)");
        test = getche();
    }while(test == 'o' || test == 'O');

    printf("\n\t AFFICHAGE DES RESULTATS");
    for(x = 0; x < EncoRes.taille; x++)
    {
        printf("\n\t* Resultat No %d : %d", x+1, EncoRes.pTabRes[x]);
        EncoRes.moy += (float) EncoRes.pTabRes[x] / EncoRes.taille;
    }
    printf("\n Moyenne : %.2f", EncoRes.moy);
    free(EncoRes.pTabRes);
    EncoRes.pTabRes = 0;
    pMem = 0;

    getch();
    return 0;
    */

    // VARIABLE STRUCTUREE DYNAMIQUE

    TestClas *pEncoRes = 0;
    int x, *pMem = 0;
    char test;

    printf("\n\t ENCODAGE DES RESULTATS");
    pEncoRes = (TestClas *) malloc(sizeof (TestClas));
    if(!pEncoRes)
    {
        printf("\n Memoire saturee - Appuyer sur une touche pour cloturer");
        getch();
        return 1;   // renvoie le code erreur en sortie du main
    }

    pEncoRes->taille = 0;
    pEncoRes[0].pTabRes = 0;
    (pEncoRes + 0)->moy = 0;
    do
    {
        pEncoRes->taille++;
        pMem = pEncoRes->pTabRes;
        pEncoRes->pTabRes = (int *) realloc(pEncoRes->pTabRes, pEncoRes->taille * sizeof (int));
        if(!pEncoRes->pTabRes)
        {
            pEncoRes->pTabRes = pMem;
            pEncoRes->taille--;
            printf("\n Memoire saturee - Appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        printf("\n\t==> Resultat No %d : ", pEncoRes->taille);
        scanf("%d", &pEncoRes->pTabRes[pEncoRes->taille-1]); getchar();
        printf("\n Encore une encodage? (o/n)");
        test = getche();
    }while(test == 'o' || test == 'O');

    printf("\n\t AFFICHAGE DES RESULTATS");
    for(x = 0; x < pEncoRes->taille; x++)
    {
        printf("\n\t* Resultat No %d : %d", x+1, pEncoRes->pTabRes[x]);
        pEncoRes->moy += (float) pEncoRes->pTabRes[x] / pEncoRes->taille;
    }
    printf("\n Moyenne : %.2f", pEncoRes->moy);
    free(pEncoRes->pTabRes);
    pEncoRes->pTabRes = 0;
    pMem = 0;
    free(pEncoRes);
    pEncoRes = 0;

    getch();
    return 0;

}

