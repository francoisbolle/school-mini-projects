// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>

typedef struct
{
    char idClas[10+1];
    char date[10+1];
    int *pTabRes;
    int taille;
    float moy;
}TestClas;

typedef struct
{
    char idEcole[10+1];
    char idProf[10+1];
    int nbclas;
    TestClas **ppTclas;
}Prof;

int reallocTestClass(TestClas ***, int);
int reallocTabRes(int **, int);
int IncTabRes(TestClas *);
int IntroRes(TestClas *);
void introClas(TestClas ***, int *);
void recapClas(TestClas **, int);
void freeClas(TestClas ***, int *);

int main(void)
{
    Prof *pTabProf = 0, *pProfMem = 0;
    int x, nbprof = 0;
    char test;

    nbprof = 0;
    do
    {
        nbprof++;
        pProfMem = pTabProf;
        pTabProf = (Prof *) realloc(pTabProf, nbprof * sizeof(Prof));
        if(!pTabProf)
        {
            pTabProf = pProfMem;
            nbprof--;
            printf("\nMemoire saturee - Appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        pTabProf[nbprof-1].ppTclas = 0;
        pTabProf[nbprof-1].nbclas = 0;
        printf("\n PROF No %d", nbprof);
        printf("\n * Identifiant de l'ecole : ");
        gets(pTabProf[nbprof - 1].idEcole);
        printf("\n * Identifiant du prof : ");
        gets(pTabProf[nbprof - 1].idProf);
        introClas(&pTabProf[nbprof-1].ppTclas, &pTabProf[nbprof-1].nbclas);
        printf("\n Un prof supplementaire (o/n) ?");
        test = getche();
    } while(test == 'o' || test == 'O');

    for(x = 0; x < nbprof; x++)
    {
        printf("\n PROF No %d", x+1);
        printf("\n * Identifiant de l'ecole : %s", pTabProf[x].idEcole);
        printf("\n * Identifiant du prof : %s", pTabProf[x].idProf);
        recapClas(pTabProf[x].ppTclas, pTabProf[x].nbclas);
    }

    for(x = 0; x < nbprof; x++)
    {
        freeClas(&pTabProf[x].ppTclas, &pTabProf[x].nbclas);
    }
    free(pTabProf);
    pTabProf = 0;

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

int IntroRes(TestClas *pTestClas)
{
int Err;
char test;
    do
    {
        Err = IncTabRes(pTestClas);
        if (Err)
        {
            printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
            getch();
            return 1;
        }
        printf("\n\t ==> Resultat copie No %d : ", pTestClas->taille);
        scanf("%d", &pTestClas->pTabRes[pTestClas->taille-1]); getchar();
        printf("\n Une autre copie? (o/n) : ");
        test = getche();
    } while (test == 'o' || test == 'O');
    return 0;
}

void introClas(TestClas ***pppTestClas, int *pnbclas)
{
int FlagStop = 0, Err;  // outil de simulation de crash
char test;
    *pnbclas = 0;
    *pppTestClas = 0;
    do
    {
        (*pnbclas)++;
        Err = reallocTestClass(pppTestClas, *pnbclas);
        if(Err)
        {
            (*pnbclas)--;
            printf("\n Memoire saturee (Code Erreur : %d) - Appuyer sur une touche pour cloturer", Err);
            getch();
            break;
        }

        printf("\n\t\t GROUPE %d - INTRODUCTION DES RESULTATS DU TEST", *pnbclas);
        printf("\n\t==> Identifiant de la classe : ");
        gets((*pppTestClas)[*pnbclas-1]->idClas);
        printf("\n\t==> Date du test : ");
        gets((*pppTestClas)[*pnbclas-1]->date);
        FlagStop = IntroRes((*pppTestClas)[*pnbclas-1]);
        if(FlagStop) break;

        printf("\n Un autre groupe? (o/n) : ");
        test = getche();
    } while (test == 'o' || test == 'O');

}

void recapClas(TestClas **pprecap, int nbclas)
{
int x, y;

    for(y = 0; y < nbclas; y++)   // boucle de balayage des groupes
    {
        printf("\n\t\t GROUPE %d - RECAPITULATIF DES RESULTATS DU TEST", y + 1);
        printf("\n\t==> Identifiant de la classe : %s", pprecap[y]->idClas);
        printf("\n\t==> Date du test : %s", pprecap[y]->date);
        for (x = 0; x < pprecap[y]->taille; x++) // boucle de balyage des copies
        {
            printf("\n\t * Resultat copie No %d : %d", x + 1, pprecap[y]->pTabRes[x]);
            pprecap[y]->moy += (float) pprecap[y]->pTabRes[x] / pprecap[y]->taille;
        }
        if (pprecap[y]->taille) printf("\n\n ==> Moyenne du groupe : %.2f", pprecap[y]->moy);
    }
}

void freeClas(TestClas ***ppplib, int *pnbclas)
{
int y;

    for(y = 0; y < *pnbclas; y++)   // boucle de libération des ressources allouées + initialisation
    {
        free((*ppplib)[y]->pTabRes); // libération de la ressource mémoire allouée
        (*ppplib)[y]->pTabRes = 0;            // sécurisation du pointeur
        free((*ppplib)[y]);
        (*ppplib)[y] = 0;
    }
    free(*ppplib);
    *ppplib = 0;
    *pnbclas = 0;
}