// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>

#define nbgrp 3

int main(void)
{
    int *Tabp[nbgrp]={0}, *pMem = 0;
    int TabTaille[nbgrp]={0}, x, y, nbclas;
    float TabMoy[nbgrp]={0};
    char test;

    x = 0;
    do  // Boucle de gestion des groupes ==> indice x
    {
        printf("\n\t\t GROUPE %d (Max %d) - INTRODUCTION DES RESULTATS DU TEST", x + 1, nbgrp);
        do  // Boucle de gestion des résultats
        {
            TabTaille[x]++;
            pMem = Tabp[x];
            Tabp[x] = (int *) realloc(Tabp[x], TabTaille[x] * sizeof(int));   // demande d'allocation mémoire
            if (!Tabp[x]) {
                Tabp[x] = pMem;
                TabTaille[x]--;
                printf("\n Memoire saturee - Appuyer sur une touche pour interrompre");
                getch();
                break;
            }
            printf("\n\t ==> Resultat copie No %d : ", TabTaille[x]);
            scanf("%d", &Tabp[x][TabTaille[x] - 1]); getchar();
            printf("\n Une autre copie? (o/n) : ");
            test = getche();
        } while (test == 'o' || test == 'O');

        x++;
        if(x < nbgrp)
        {
            printf("\n Un autre groupe? (o/n) : ");
            test = getche();
        }
        else break;
    } while (test == 'o' || test == 'O');

    pMem = 0;
    nbclas = x;
    for(y = 0; y < nbclas; y++)   // boucle de balayage des groupes
    {
        printf("\n\t\t GROUPE %d - RECAPITULATIF DES RESULTATS DU TEST", y + 1);
        for (x = 0; x < TabTaille[y]; x++) // boucle de balyage des copies
        {
            printf("\n\t * Resultat copie No %d : %d", x + 1, Tabp[y][x]);
            TabMoy[y] += (float) Tabp[y][x] / TabTaille[y];
        }
        if (TabTaille[y]) printf("\n\n ==> Moyenne du groupe : %.2f", TabMoy[y]);
    }

    for(y = 0; y < nbclas; y++)   // boucle de libération des ressources allouées + initialisation
    {
        free(Tabp[y]); // libération de la ressource mémoire allouée
        Tabp[y] = 0;            // sécurisation du pointeur
        TabTaille[y] = 0;
        TabMoy[y] = 0;
    }

    getch();
    return 0;
}

