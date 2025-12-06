#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

// Gestion de tableaux

void main()
{
    char TabCar[7+1];
    int x = 0, taille = 0, Fstop = 0;

    printf("\nIntroduction du code (min 3 car - max 7 car): ");
    //gets(TabCar);
    do
    {
        TabCar[x] = getch();

        switch(TabCar[x])
        {
            case 13:    // confirmation "ENTER"
            //    Fstop = 1;

                if(x > 2) Fstop = 1;  // demande de dégagement de la boucle DO-While - Condition: Longueur minimale du code de 3 car.
                else
                {
                    TabCar[x] = 0;
                    //printf("\n\t==> Minimum 3 car : %s", TabCar);
                    printf("\n\t==> Minimum 3 car : ");
                    x = 0;
                    while (TabCar[x])
                    {
                        printf("*");
                        x++;
                    }
                }

                break;  // dégagement du switch
            case 8:     // BackSpace
                if(x)
                {
                    printf("\b \b");
                    x--;   // x = x - 1
                }
                break;  // dégagement du switch
            case 27:    // détection et neutralisation ESC
            case '\t':     // case 9 ==> détection et neutralisation TAB
                break;
            case -32:   // détection et neutralisation des touches Flèches
            case 0:     // détection et neutralisation des touches Fx
                TabCar[x] = getch();
                break;

            default:    // caractère affichable
                //if(0) break; //détection et neutralisation des touches ...
                if(x < 7)
                {
                    //printf("%c", TabCar[x]);
                    printf("*");
                    x++;    // x = x + 1
                }
                else
                {
                    TabCar[x] = 0;
                    //printf("\n\t==> Maximum 7 car (Confirmer / Modifier): %s", TabCar);
                    printf("\n\t==> Maximum 7 car (Confirmer / Modifier): ");
                    printf("*******");
                }

                break;  // dégagement du switch
        }

        //if(Fstop) break;
    } while (!Fstop);  // Fstop == 0
    TabCar[x] = 0;
    taille = x;

    //printf("\nLe code introduit est: %s", TabCar);
    printf("\nLe code introduit est: ");

    /*
    x = 0;
    while(TabCar[x])
    {
        printf("%c", TabCar[x]);
        x++;
    }
    */

    /*
    for(x = 0; x < taille; x++)
    {
        printf("%c", TabCar[x]);
    }
    */

    for(x = 0; TabCar[x]; x++)
    {
        printf("%c", TabCar[x]);
    }
    getch();
}

