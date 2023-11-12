namespace GraphQlApitest.Models
{
    /*
     * Modele :Owner
     */
    public class Owner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        // un propriétaire peut posserder plusieur type de compte différents
        public ICollection<Account> Accounts { get; set; }
    }
}
