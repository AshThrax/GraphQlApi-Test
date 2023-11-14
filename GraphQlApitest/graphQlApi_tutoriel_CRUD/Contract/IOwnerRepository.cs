using graphQlApi_tutoriel_CRUD.Entities;

namespace graphQlApi_tutoriel_CRUD.Contract
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
    }
}
