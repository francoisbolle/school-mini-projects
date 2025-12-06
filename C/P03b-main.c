#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

void main()
{
    char intro;
    //int a;

    do
    {
        printf("\n\t * Appuyer sur une touche clavier : ");
        intro = getch();
        if(intro == 13) printf("\n\n ==> Le code ASCII de la touche \"ENTER\" est %02Xh, soit %d en decimal", intro, intro);
        else if (intro == 0)  // détection Fx
        {
            intro = getch();    // acquisition du second code ASCII au sein du buffer clavier
            printf("\n\n ==> Les codes ASCII de la touche \"Fx\" sont 00h - %02Xh, soit 0 - %d en decimal", intro,intro);
        }
        else printf("\n\n ==> Le code ASCII de la touche \"%c\" est %02Xh, soit %d en decimal", intro, intro, intro);
        printf(" - Appuyer sur Q pour quitter");
        intro = getch();
        //a = intro == 'q';
        if(intro == 'q' || intro == 'Q') break;
    }while(1);   //while(!(intro == 'q' || intro == 'Q')); //while(!(!(intro != 'q') || !(intro != 'Q')));   // while(intro != 'q' && intro != 'Q');

}

