using tp2;

class ComptePayant : Compte
{
    private static int nombreOperation = 0;
    private double commission;
    

    public double getCommision()
    {
        return commission;
    }

    public int getNombreOperation()
    {
        return nombreOperation;
    }

    public void setCommision(double commision)
    {
        this.commission = commision;
    }


    public ComptePayant(double commision, int numero, string nom, double solde)
    {
        nombreOperation++;
        this.commission = commision;
        this.numero = numero;
        this.nom = nom;
        this.solde = solde;
    }

    public void Afficher()
    {
        Console.WriteLine(numero + " / " + nom + " / " + solde + " / " + commission + " / " + nombreOperation);
    }
}