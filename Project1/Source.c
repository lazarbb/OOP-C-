#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
struct cvor {
    char x;
    struct cvor* lijevi;
    struct cvor* desni;
}typedef cvor;

int nadjen;
cvor* nadredjeni;

void find(char P, cvor* cvor) {
    if (cvor == NULL) return;
    if (cvor->x == P) {
        nadjen = 1;
        return;
    }
    nadredjeni = cvor;
    if (cvor->x > P)find(P, cvor->lijevi);
    else find(P, cvor->desni);

}


void add(char P, cvor** korijen) {

    nadjen = -1;
    nadredjeni = NULL;
    find(P, *korijen);

    if (nadjen == 1) return;

    else {
        cvor* n = (cvor*)malloc(sizeof(cvor));
        n->x = P;
        n->desni = NULL;
        n->lijevi = NULL;

        if (nadredjeni == NULL)*korijen = n;
        else
        {
            if (P < nadredjeni->x)
            {
                nadredjeni->lijevi = n;
            }
            else
            {
                nadredjeni->desni = n;
            }
        }

    }
}

void preorder(cvor* cvor) {

    printf("%c", cvor->x);

    if (cvor->lijevi != NULL)
    {
        preorder(cvor->lijevi);
    }
    if (cvor->desni != NULL)
    {
        preorder(cvor->desni);
    }
}

void inorder(cvor* cvor) {

    if (cvor->lijevi != NULL)
    {
        inorder(cvor->lijevi);
    }
    printf("%c", cvor->x);

    if (cvor->desni != NULL)
    {
        inorder(cvor->desni);
    }
}

void postorder(cvor* cvor) {

    if (cvor->lijevi != NULL)
    {
        postorder(cvor->lijevi);
    }

    if (cvor->desni != NULL)
    {
        postorder(cvor->desni);
    }
    printf("%c", cvor->x);

}

int main()
{
    cvor* korijen = NULL;

    char c;

    c = getchar();
    while (c != '\n')
    {

        add(c, &korijen);
        c = getchar();
    }

    preorder(korijen);
    printf("\n");
    inorder(korijen);
    printf("\n");
    postorder(korijen);


    return 0;
}