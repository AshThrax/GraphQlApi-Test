using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace graphQlApi_tutoriel_CRUD.Entities.Context.Configuration
{
    public class AccountConfiguration:IEntityTypeConfiguration<Account>
    {
        private Guid[] _ids;

        public AccountConfiguration(Guid[] ids)
        { 
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Account> builder) 
        {
            builder.HasData(
                new Account { Id=new Guid(), Type = AccountType.cash, Description = "cash account for user", OwnerId = _ids[0] },
                new Account { Id = new Guid(), Type = AccountType.Savings, Description = "saving Accounts for our users", OwnerId = _ids[0] },
                new Account { Id = new Guid(), Type = AccountType.Savings, Description = "saving Accounts for our users", OwnerId = _ids[1] }
                ); 
        }
    }
}
