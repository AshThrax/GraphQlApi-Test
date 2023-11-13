using System.ComponentModel.DataAnnotations;

namespace graphQlApi_tutoriel_CRUD.Entities
{
    public class Owner
    {
        [Key]
        public  Guid Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
