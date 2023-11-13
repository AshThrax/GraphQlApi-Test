using graphQlApi_tutoriel_CRUD.Contract;
using graphQlApi_tutoriel_CRUD.Entities.Context;

namespace graphQlApi_tutoriel_CRUD.Repository
{
    public class OwnerRepository:IOwnerRepository
    {
        private readonly ApplicationDbContext _context;

        public OwnerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
