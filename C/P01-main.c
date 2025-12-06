#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

//Commentaire sur une ligne
/*
 * Commentaires sur un zone
 */

void main()
{
    int x = 98, y;          // entier signé ==> %d
    unsigned int z = 9;     // entier non signé ==> %u
    char test = 'z';        // caractère ==> %c
    float reel = 3.14;      // réel ==> %f


    printf("\n\n\t * Introduction de l'entier signe x : ");
    scanf("%d",&x); getchar();
    printf("\n * Adresse de x = %08Xh- Valeur de x = %08Xh - En decimal signe = %d - En decimal non signe = %u",&x, x, x, x);
    y = sizeof(int);
    printf("\nLa variable x est stockee sur %d octets", y);

    printf("\n\n\t * Introduction de l'entier non signe z : ");
    scanf("%u",&z); getchar();
    printf("\n * Adresse de z = %08Xh- Valeur de z = %08Xh - En decimal signe = %d - En decimal non signe = %u",&z, z, z, z);
    y = sizeof(unsigned int);
    printf("\nLa variable z est stockee sur %d octets", y);

    printf("\n\n\t * Introduction du caractere test : ");
    // scanf("%c",&test); getchar();
    test = getche();
    printf("\n * Adresse de \"test\" = %08Xh- Valeur de \"test\" = %02Xh - Valeur = %c",&test, test, test);
    y = sizeof(char);
    printf("\nLa variable \"test\" est stockee sur %d octets", y);

    printf("\n\n\t * Introduction du reel : ");
    scanf("%f",&reel); getchar();
    printf("\n * Adresse de \"reel\" = %08Xh- Valeur de \"reel\" = %08Xh - En decimal = %.2f",&reel, reel, reel);
    y = sizeof(float);
    printf("\nLa variable \"reel\" est stockee sur %d octets", y);

    getch();
}

