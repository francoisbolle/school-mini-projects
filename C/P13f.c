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

int reallocTestClass(TestClas ***, int);
int reallocTabRes(int **, int);
int IncTabRes(TestClas *);


int main(void)
{
    TestClas **ppTclas = 0;
    int x, y, nbclas, FlagStop = 0, Err;  // outil de simulation de crash
    char test;

    nbclas = 0;
    do
    {
        nbclas++;
        Err = reallocTestClass(&ppTclas, nbclas);
        if(Err)
        {
            nbclas--;
            printf("\n Memoire saturee (Code Erreur : %d) - Appuyer sur une touche pour cloturer", Err);
            getch();
            break;
        }
        
        printf("\n\t\t GROUPE %d - INTRODUCTION DES RESULTATS DU TEST", nbclas);
        do
        {
            Err = IncTabRes(ppTclas[nbclas-1]);
            if (Err)
            {
                printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
                getch();
                FlagStop = 1;
                break;
            }
            printf("\n\t ==> Resultat copie No %d : ", ppTclas[nbclas-1]->taille);
            scanf("%d", &ppTclas[nbclas-1]->pTabRes[ppTclas[nbclas-1]->taille-1]); getchar();
            printf("\n Une autre copie? (o/n) : ");
            test = getche();
        } while (test == 'o' || test == 'O');
        if(FlagStop) break;

        printf("\n Un autre groupe? (o/n) : ");
        test = getche();
    } while (test == 'o' || test == 'O');

    for(y = 0; y < nbclas; y++)   // boucle de balayage des groupes
    {
        printf("\n\t\t GROUPE %d - RECAPITULATIF DES RESULTATS DU TEST", y + 1);
        for (x = 0; x < ppTclas[y]->taille; x++) // boucle de balyage des copies
        {
            printf("\n\t * Resultat copie No %d : %d", x + 1, ppTclas[y]->pTabRes[x]);
            ppTclas[y]->moy += (float) ppTclas[y]->pTabRes[x] / ppTclas[y]->taille;
        }
        if (ppTclas[y]->taille) printf("\n\n ==> Moyenne du groupe : %.2f", ppTclas[y]->moy);
    }

    for(y = 0; y < nbclas; y++)   // boucle de libération des ressources allouées + initialisation
    {
        free(ppTclas[y]->pTabRes); // libération de la ressource mémoire allouée
        ppTclas[y]->pTabRes = 0;            // sécurisation du pointeur
        free(ppTclas[y]);
        ppTclas[y] = 0;
    }
    free(ppTclas);
    ppTclas= 0;

    getch();
    return 0;
}

int reallocTestClass(TestClas ***pppTclas, int taille)
{
    TestClas **ppMclas = 0;

    ppMclas = *pppTclas;
    *pppTclas = (TestClas **) realloc(*pppTclas, taille * sizeof(TestClas *));
    if(!*pppTclas)
    {
        *pppTclas = ppMclas;
        return 1;       // renvoie le code Err "realloc sur Tab *"
    }
    ppMclas = 0;
    (*pppTclas)[taille-1] = 0;  // mise à 0 du dernier pointeur reçu
    (*pppTclas)[taille-1] = (TestClas *) malloc(sizeof(TestClas));
    if(!(*pppTclas)[taille-1])
    {
       return 2;        // renvoie le code Err "malloc sur *"
    }
    (*pppTclas)[taille-1]->pTabRes = 0;
    (*pppTclas)[taille-1]->taille = 0;
    (*pppTclas)[taille-1]->moy = 0;
    return 0;
}

int reallocTabRes(int **ppTabRes, int taille)
{
    int *pMem = 0;

    pMem = *ppTabRes;
    *ppTabRes = (int *) realloc(*ppTabRes, taille * sizeof(int));
    if (!*ppTabRes)
    {
        *ppTabRes = pMem;
        return 1;   // renvoie le code erreur
    }
    pMem = 0;
    return 0;   // code Realloc OK
}

int IncTabRes(TestClas *pTestClas)
{
int Err;

    pTestClas->taille++;
    Err = reallocTabRes(&pTestClas->pTabRes, pTestClas->taille);
    if (Err) pTestClas->taille--;
    return Err;
}