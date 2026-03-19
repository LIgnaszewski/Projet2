namespace tp2;
using System;

class Program
{
    static void Main()
    {
        Compte c1 = new Compte();

        c1.SetNumero(20);
        c1.SetNom("Farid");
        c1.SetSolde(1500);

        CompteEpargne ce1 = new CompteEpargne(0.03, "15/01/2024", 21, "Gina", 1000);

        ComptePayant cp1 = new ComptePayant(3, 22, "Hugo", 700);

        c1.Afficher();
        ce1.Afficher();
        cp1.Afficher();
    }
}