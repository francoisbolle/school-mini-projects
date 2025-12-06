#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

// Gestion de tableaux

void main()
{
    char TabCar[7+1];
    int x = 0;

    printf("\nIntroduction du code (max 7 car): ");
    //gets(TabCar);
    do
    {
        TabCar[x] = getch();
        if(TabCar[x] == 13) break;
        if(TabCar[x] == 8 &&  x)
        {
            printf("\b \b");
            x--;   // x = x - 1
        }
        else if(TabCar[x] != 8)
        {
            printf("%c",TabCar[x]);
            x++;    // x = x + 1
        }

    } while (x < 7);
    TabCar[x] = 0;

    printf("\nLe code introduit est: %s", TabCar);

    getch();
}

