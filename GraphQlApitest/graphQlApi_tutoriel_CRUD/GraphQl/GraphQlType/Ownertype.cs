using GraphQL.Types;
using graphQlApi_tutoriel_CRUD.Entities;

namespace graphQlApi_tutoriel_CRUD.GraphQl.GraphQlType
{
    public class Ownertype : ObjectGraphType<Owner>
    {
        public Ownertype()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property From the owner Object");
            Field(x => x.Name).Description("Name Property From the owner Object");
            Field(x => x.Address).Description("Address property from the owner Object");
        }
    }
}
