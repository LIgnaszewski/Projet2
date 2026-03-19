using tp2;

class CompteEpargne : Compte
{
    private double tauxInteret;
    private string dateOuverture;

    public double getTauxInteret()
    {
        return tauxInteret;
    }
    public void setTauxInteret(double tauxInteret)
    {
        this.tauxInteret = tauxInteret;
    }
    public string getDateOuverture()
    {
        return dateOuverture;
    }

    public void setDateOuverture(string dateOuverture)
    {
        this.dateOuverture = dateOuverture;
    }

    public void Afficher()
    {
        Console.WriteLine(numero + " / " + nom + " / " + solde + " / " + tauxInteret + " / " + dateOuverture);
    }

    public bool Debiter(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : le montant à débiter doit être strictement positif.");
            return false;
        }

        // Règle finale du sujet : découvert autorisé jusqu'à -200 €
        if (solde - montant < 0)
        {
            Console.WriteLine("Erreur : débit refusé, découvert maximal dépassé.");
            return false;
        }

        solde -= montant;
        return true;
    }

    public CompteEpargne(double tauxInteret, string dateOuverture, int numero, string nom, int solde)
    {
        this.tauxInteret = tauxInteret;
        this.dateOuverture = dateOuverture;
        this.numero = numero;
        this.nom = nom;
        this.solde = solde;
    }
}