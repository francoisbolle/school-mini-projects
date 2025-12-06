// Gestion mémoire dynamique

#include <conio.h>
#include <malloc.h>
#include <stdio.h>

int main(void)
{
    int *pTab = 0;
    int taille = 5, x;

    printf("\n\t\t INTRODUCTION DES RESULTATS DU TEST");
    printf("\n * Nombre de resultats a encoder : ");
    scanf("%d", &taille); getchar();
    pTab = (int *) malloc(taille * sizeof (int));   // demande d'allocation mémoire
    if(!pTab)
    {
        printf("\n --- Memoire systeme saturee - Appuyer sur une touche pour cloturer ---");
        getch();
        return 1;
    }
    for(x = 0; x < taille; x++)
    {
        printf("\n\t ==> Resultat copie No %d : ", x+1);
        scanf("%d", &pTab[x]); getchar();
    }

    printf("\n\t\t RECAPITULATIF DES RESULTATS DU TEST");
    for(x = 0; x < taille; x++)
    {
        printf("\n\t * Resultat copie No %d : %d", x+1, pTab[x]);
    }

    free(pTab); // libération de la ressource mémoire allouée
    pTab = 0;
    getch();

    return 0;
}

