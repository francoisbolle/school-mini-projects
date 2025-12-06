// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>


void main()
{
    int x = 5, *px = 0;

    printf("\n Adresse de x : %0Xh - Valeur de x : %d", &x, x);
    printf("\n Adresse de px : %0Xh - Valeur de px : %0Xh", &px, px);

    px = &x;    // initialisation du pointeur sur sa cible
    printf("\n Adresse de px : %0Xh - Valeur de px : %0Xh - Cible de px : %d", &px, px, *px);
    (*px)++;    //px[0]++;    //(*(px + 0))++;  //*px += 1;   //*px = *px + 1;  //px++ = *px++ ==> INCREMENTATION (4 octets - taille entier) DU POINTEUR !!!
    printf("\n Adresse de px : %0Xh - Valeur de px : %0Xh - Cible de px : %d", &px, px, *px);

    getch();
}

