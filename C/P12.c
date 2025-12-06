// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>


int main(void)
{
    int **ppTabp = 0, **ppMem = 0, *pTabTaille = 0, *pMem = 0;
    int x, y, nbclas, FlagStop = 0, crash = 0;  // outil de simulation de crash
    float *pTabMoy = 0, *pMemf = 0;
    char test;

    nbclas = 0;
    do
    {
        nbclas++;
        ppMem = ppTabp;
        ppTabp = (int **) realloc(ppTabp, nbclas * sizeof(int *));
        if(!ppTabp)
        {
            ppTabp = ppMem;
            nbclas--;
            printf("\n Erreur allocation ppTabp - Memoire saturee, appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        ppTabp[nbclas-1] = 0;

        pMem = pTabTaille;
        pTabTaille = (int *) realloc(pTabTaille, nbclas * sizeof(int));
        if(!pTabTaille)
        {
            pTabTaille = pMem;
            nbclas--;
            printf("\n Erreur allocation pTabTaille - Memoire saturee, appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        pTabTaille[nbclas-1] = 0;

        pMemf = pTabMoy;
        pTabMoy = (float *) realloc(pTabMoy, nbclas * sizeof(float));
        if(!pTabMoy)
        {
            pTabMoy = pMemf;
            nbclas--;
            printf("\n Erreur allocation pTabMoy - Memoire saturee, appuyer sur une touche pour cloturer");
            getch();
            break;
        }
        pTabMoy[nbclas-1] = 0;

        printf("\n\t\t GROUPE %d - INTRODUCTION DES RESULTATS DU TEST", nbclas);
        do
        {
            pTabTaille[nbclas-1]++;
            pMem = ppTabp[nbclas-1];
            ppTabp[nbclas-1] = (int *) realloc(ppTabp[nbclas-1], pTabTaille[nbclas-1] * sizeof(int));   // demande d'allocation mémoire
            if (!ppTabp[nbclas-1] || crash)
            {
                ppTabp[nbclas-1] = pMem;
                pTabTaille[nbclas-1]--;
                printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
                getch();
                FlagStop = 1;
                break;
            }
            printf("\n\t ==> Resultat copie No %d : ", pTabTaille[nbclas-1]);
            scanf("%d", &ppTabp[nbclas-1][pTabTaille[nbclas-1] - 1]); getchar();
            printf("\n Une autre copie? (o/n) : ");
            test = getche();
        } while (test == 'o' || test == 'O');
        if(FlagStop) break;

        printf("\n Un autre groupe? (o/n) : ");
        test = getche();
    } while (test == 'o' || test == 'O');

    ppMem = 0;
    pMem = 0;
    pMemf = 0;

    for(y = 0; y < nbclas; y++)   // boucle de balayage des groupes
    {
        printf("\n\t\t GROUPE %d - RECAPITULATIF DES RESULTATS DU TEST", y + 1);
        for (x = 0; x < pTabTaille[y]; x++) // boucle de balyage des copies
        {
            printf("\n\t * Resultat copie No %d : %d", x + 1, ppTabp[y][x]);
            pTabMoy[y] += (float) ppTabp[y][x] / pTabTaille[y];
        }
        if (pTabTaille[y]) printf("\n\n ==> Moyenne du groupe : %.2f", pTabMoy[y]);
    }

    for(y = 0; y < nbclas; y++)   // boucle de libération des ressources allouées + initialisation
    {
        free(ppTabp[y]); // libération de la ressource mémoire allouée
        ppTabp[y] = 0;            // sécurisation du pointeur
    }
    free(ppTabp);
    ppTabp = 0;
    free(pTabTaille);
    pTabTaille = 0;
    free(pTabMoy);
    pTabMoy = 0;

    getch();
    return 0;
}

