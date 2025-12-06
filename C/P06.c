// Gestion pointeurs

#include <stdio.h>
#include <conio.h>
// #include <stdlib.h>

// Zone de déclaration des fonctions
void fct1(void);
int fct2(void);
void fct3(int);
int fct4(int, int);
int fct5(int);
void fct6(int *, int *);
void fct7(int *);
void fct8(int *);

void main()
{
    int x = 99, y;
    int TabIntro[10];   // fct7 - fct8 ==> acquisition et affichage du tableau


    fct1(); // point d'appel
    printf("\nPRINCIPAL");
    printf("\n X = %d",x);
    fct1(); // point d'appel

    x = fct2(); // point d'appel
    printf("\nPRINCIPAL");
    printf("\n Lancement No %d de fct2",x);
    x = fct2(); // point d'appel
    printf("\nPRINCIPAL");
    printf("\n Lancement No %d de fct2",x);

    fct3(56);
    fct3(99);

    //printf("\n Fct4 => Introduction de N1 : ");
    //scanf("%d",&x); getchar();
    //x = fct5(1);
    //printf("\n Fct4 => Introduction de N2 : ");
    //scanf("%d",&y); getchar();
    //y = fct5(2);
    fct6(&x, &y);

    x = fct4(x,y);
    printf("\n Fct4 => N1 + N2 = %d ", x);
    //printf("\n Fct4 => N1 + N2 = %d ", fct4(x,y));

    printf("\n Introduction des 10 elements du tableau");
    fct7(TabIntro); // fct7(&TabIntro[0]);
    fct8(&TabIntro[0]);

    getch();
}

//Zone des définitions de fonctions

void fct1(void) // définition
{
    //int x, y = 0;
    register int x;     // requête de stockage de la variable dans un registre du uP
    static int y = 0;   // variable instanciée au 1er lancement de la fonction et maintenue en mémoire après clôture

    printf("\n\nFCT1 - Lancement No %d", ++y);
    for(x = 0; x < 10; x++)
    {
        printf("\n X = %d", x);
    }
}

int fct2(void) // définition
{
    int x = 0;          // variable classique : instanciée (et initialisée) à chaque lancement de la fonction (elle meurt avec la fonction)
    static int y = 0;

    printf("\n\nFCT2 - Lancement No %d", ++y);
    for(x = 0; x < 10; x++)
    {
        printf("\n X = %d", x);
    }

    return y;
}

void fct3(int x)
{
    printf("\nFct3 => Valeur capturee : %d", x);
}

int fct4(int a, int b)
{
    int somme;

    somme = a + b;
    return somme;
    // return a + b;
}

int fct5(int num)
{
    int x;

    printf("\n Fct5 => Introduction de N%d : ", num);
    scanf("%d",&x); getchar();
    return x;
}

void fct6(int *px, int *py)
{
    printf("\n Fct6 => Introduction de N1 : ");
    scanf("%d",px); getchar();

    printf("\n Fct6 => Introduction de N2 : ");
    scanf("%d",&*py); getchar();
}

void fct7(int *pTabIntro)
{
    int x, *pdebug = pTabIntro; // pilote le mode "view as array" en debug si incrémentation pTabIntro

    for(x = 0; x < 10; x++)
    {
        printf("\n\t==> Element No %d : ",x+1);
        //scanf("%d", &pTabIntro[x]); getchar();
        scanf("%d", pTabIntro++); getchar();
        //scanf("%d", pTabIntro + x); getchar();
        //scanf("%d", &*(pTabIntro + x)); getchar();
    }
}

void fct8(int *pTabIntro)
{
    int x;
    printf("\n\nRecapitulatif du tableau:");
    for(x = 0; x < 10; x++)
    {
        //printf("\n\t==> Element No %d : %d",x+1, pTabIntro[x]);
        printf("\n\t==> Element No %d : %d",x+1, *pTabIntro++);
    }
}