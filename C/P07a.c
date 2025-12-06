// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>
#define taille 10

int introS(char *, int min, int max, int hide, int alpha);  // alpha = 1 ==> enco alphanum sinon num seul

void main()
{
    //const int Taille = 20;  // aucune utilité car valeur fixe et définie lors de la compilation
    char TCodeS[taille + 1];
    int erreur;
    char test;

    do
    {
        printf("\n Type d'introduction souhaite (Clair -> 0 / cache -> 1)");
        scanf("%d", &erreur); getchar();
    } while (erreur != 0 && erreur != 1);

    do
    {
        printf("\n Type d'introduction souhaite (Code -> 0 / Pswd -> 1)");
        test = getche();
    } while (test != '0' && test != '1');

    erreur = introS(TCodeS, 3, taille, erreur, test == '1');    // test == '1' ==> génération 0/1 numérique (true/false) pour alimenter alpha
    if(!erreur) printf("\n\n\t * Le code introduit est : %s", TCodeS);

    getch();
}

int introS(char *pTintro, int min, int max, int hide, int alpha)
{
    int x = 0, y, Fstop = 0;

    if(min > max)
    {
        printf("\n APPEL DE FONCTION INCOHERENT : max < min");
        return 1;   // renvoi du code erreur incohérence min - max
    }
    printf("\nIntroduction du code (min %d chiffres - max %d): ", min, max);

    do
    {
        pTintro[x] = getch();

        switch(pTintro[x])
        {
            case 13:    // confirmation "ENTER"
                //    Fstop = 1;

                if(x >= min) Fstop = 1;  // demande de dégagement de la boucle DO-While - Condition: Longueur minimale du code de 3 car.
                else
                {
                    pTintro[x] = 0;
                    printf("\n\t==> Minimum %d chiffres : ", min);
                    if(hide)
                    {
                        x = 0;
                        while (pTintro[x])
                        {
                            printf("*");
                            x++;
                        }
                    }
                    else printf("%s", pTintro);
                }

                break;  // dégagement du switch
            case 8:     // BackSpace
                if(x)
                {
                    printf("\b \b");
                    x--;
                }
                break;  // dégagement du switch
            case 27:    // détection et neutralisation ESC
            case '\t':     // case 9 ==> détection et neutralisation TAB
                break;
            case -32:   // détection et neutralisation des touches Flèches
            case 0:     // détection et neutralisation des touches Fx
                pTintro[x] = getch();
                break;

            default:    // caractère affichable
                //if(0) break; //détection et neutralisation des touches ...
                if(x < max)
                {
                    if(pTintro[x] >= '0' && pTintro[x] <= 0x39 || alpha)   // restriction de la frappe sur des valeurs numériques
                    {
                        if(hide) printf("*");
                        else printf("%c", pTintro[x]);
                        x++;
                    }
                }
                else
                {
                    pTintro[x] = 0;
                    printf("\n\t==> Maximum %d chiffres (Confirmer / Modifier): ", max);
                    if(hide) for(y = 0; y < max; y++) printf("*");
                    else printf("%s", pTintro);
                }

                break;  // dégagement du switch
        }

    } while (!Fstop);  // Fstop == 0
    pTintro[x] = 0;
    return 0;   // code erreur non activé
}


