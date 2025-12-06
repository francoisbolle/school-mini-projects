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
    TestClas *pTclas = 0, *pMclas = 0;
    int *pMem = 0;
    int x, y, nbclas, FlagStop = 0;  // outil de simulation de crash
    char test;

    nbclas = 0;
    do
    {
        nbclas++;
        pMclas = pTclas;
        pTclas = (TestClas *) realloc(pTclas, nbclas * sizeof(TestClas));
        if(!pTclas)
        {
            pTclas = pMclas;
            nbclas--;
            printf("\n Memoire saturee - appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        pTclas[nbclas-1].pTabRes = 0;
        pTclas[nbclas-1].taille = 0;
        pTclas[nbclas-1].moy = 0;

        printf("\n\t\t GROUPE %d - INTRODUCTION DES RESULTATS DU TEST", nbclas);
        do
        {
            pTclas[nbclas-1].taille++;
            pMem = pTclas[nbclas-1].pTabRes;
            pTclas[nbclas-1].pTabRes = (int *) realloc(pTclas[nbclas-1].pTabRes, pTclas[nbclas-1].taille * sizeof(int));
            if (!pTclas[nbclas-1].pTabRes)
            {
                pTclas[nbclas-1].pTabRes = pMem;
                pTclas[nbclas-1].taille--;
                printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
                getch();
                FlagStop = 1;
                break;
            }
            printf("\n\t ==> Resultat copie No %d : ", pTclas[nbclas-1].taille);
            scanf("%d", &pTclas[nbclas-1].pTabRes[pTclas[nbclas-1].taille-1]); getchar();
            printf("\n Une autre copie? (o/n) : ");
            test = getche();
        } while (test == 'o' || test == 'O');
        if(FlagStop) break;

        printf("\n Un autre groupe? (o/n) : ");
        test = getche();
    } while (test == 'o' || test == 'O');
    pMclas = 0;
    pMem = 0;

    for(y = 0; y < nbclas; y++)   // boucle de balayage des groupes
    {
        printf("\n\t\t GROUPE %d - RECAPITULATIF DES RESULTATS DU TEST", y + 1);
        for (x = 0; x < pTclas[y].taille; x++) // boucle de balyage des copies
        {
            printf("\n\t * Resultat copie No %d : %d", x + 1, pTclas[y].pTabRes[x]);
            pTclas[y].moy += (float) pTclas[y].pTabRes[x] / pTclas[y].taille;
        }
        if (pTclas[y].taille) printf("\n\n ==> Moyenne du groupe : %.2f", pTclas[y].moy);
    }

    for(y = 0; y < nbclas; y++)   // boucle de libération des ressources allouées + initialisation
    {
        free(pTclas[y].pTabRes); // libération de la ressource mémoire allouée
        pTclas[y].pTabRes = 0;            // sécurisation du pointeur
    }
    free(pTclas);
    pTclas= 0;

    getch();
    return 0;
}

