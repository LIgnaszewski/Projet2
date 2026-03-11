using System;
class Compte
{
    public string nom {get; set;}
    public int numero { get; set; }
    public int solde { get; set; }

    public void Debiter(int montant)
    {
        if ((solde-montant) > -200 && montant > 0) solde -= montant;
        else Console.WriteLine("Solde Insufisant");
    }

    public void Crediter(int montant)
    {
        if (montant > 0) solde += montant;
        else Console.WriteLine("Montant Insufisant");
    }

    public void Transfert(Compte compteIn, Compte compteOut, int montant)
    {
        if (compteIn != compteOut)
        {
            compteIn.Debiter(montant);
            compteOut.Crediter(montant);   
        } else Console.WriteLine("Transfert vers le même compte interdit");
    }

    public void Afficher()
    {
        Console.WriteLine($"Nom : {nom}, Numero : {numero}, solde : {solde}");
    }
}
class Program
{   
    static void Main(string[] args)
    {
        Compte c1 = new Compte() { numero = 1, nom = "feur", solde = 9999 };
        Compte c2 = new Compte() { numero = 2, nom = "kqzd", solde = 99 };
        Compte c3 = new Compte() { numero = 3, nom = "fffffffffff", solde = 999 };
        Compte c4 = c1;

        c1.Crediter(500);
        c4.Debiter(100);

        List<Compte> comptes = new List<Compte>();
        comptes.Add(c1);
        comptes.Add(c2);
        comptes.Add(c3);
        comptes.Add(c4);

        foreach (var compte in comptes)
        {
            compte.Afficher();
        };
    }
}