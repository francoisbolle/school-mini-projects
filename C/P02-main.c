#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

void main()
{
    char intro;

    printf("\n\t * Appuyer sur une touche clavier : ");
    intro = getche();
    printf("\n\n ==> Le code ASCII de la touche enfoncee est %02Xh, soit %d en decimal", intro, intro);
    printf("\n\n ==> Le code ASCII de la touche \"%c\" est %02Xh, soit %d en decimal", intro, intro, intro);


    intro = getch();
    getch();
}

