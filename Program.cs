namespace tp2;
using System;

class Program
{
    static void Main()
    {
        CompteEpargne ce1 = new CompteEpargne(0.04, "01/09/2024", 10, "Diane", 800);

        ce1.Crediter(100);
        ce1.Debiter(200);
        ce1.Debiter(800);
        ce1.Afficher();

        ComptePayant cp1 = new ComptePayant(2, 11, "Emma", 600);

        cp1.Crediter(50);
        cp1.Debiter(100);
        cp1.Debiter(50);
        cp1.Afficher();
    }
}