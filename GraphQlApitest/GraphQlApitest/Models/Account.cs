namespace GraphQlApitest.Models
{
    
    public class Account
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public TypeOfAccount type { get; set;}
    }
    
    //enumerateur avec le type de compte 
    public enum TypeOfAccount
    {
        Cash,
        Savings,
        Expense,
        Income
    } 
    
}
