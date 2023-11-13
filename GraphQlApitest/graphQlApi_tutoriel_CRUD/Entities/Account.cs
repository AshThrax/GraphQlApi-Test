using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace graphQlApi_tutoriel_CRUD.Entities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="")]
        public AccountType Type { get; set; }
        public string Description { get; set; }
        [ForeignKey("OwnerId")]
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }

    public enum AccountType
    {
        cash,Savings,Expense,Income
    }
}
