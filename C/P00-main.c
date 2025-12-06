#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

//Commentaire sur une ligne
/*
 * Commentaires sur un zone
 */

void main()
{
    int x = 98, y;  // entier signé

    printf("\n Introduction de x : ");
    scanf("%d",&x); getchar();
    printf("\n * Adresse de x = %08Xh- Valeur de x = %08Xh - En decimal signe = %d - En decimal non signe = %u",&x, x, x, x);
    y = sizeof(int);
    printf("\nLa variable x est stockee sur %d octets", y);


    getch();
}

