using graphQlApi_tutoriel_CRUD.Contract;
using graphQlApi_tutoriel_CRUD.Entities.Context;

namespace graphQlApi_tutoriel_CRUD.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
