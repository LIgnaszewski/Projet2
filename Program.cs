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

        c1.Crediter(200);
        c1.Debiter(400);
        c1.Afficher();

        CompteEpargne ce1 = new CompteEpargne(0.03, "15/01/2024", 21, "Gina", 1000);

        ce1.Crediter(150);
        ce1.Debiter(300);
        ce1.Debiter(1000);
        ce1.Afficher();

        ComptePayant cp1 = new ComptePayant(3, 22, "Hugo", 700);
        
        cp1.Crediter(100);
        cp1.Debiter(200);
        cp1.Debiter(50);
        cp1.Afficher();

        Compte.Transferer(c1, ce1, 100);
        Compte.Transferer(ce1, cp1, 50);
        Compte.Transferer(cp1, c1, 2000);

        Console.WriteLine("Après transfert : ");
        ce1.Afficher();
        cp1.Afficher();
        c1.Afficher();
    }
}