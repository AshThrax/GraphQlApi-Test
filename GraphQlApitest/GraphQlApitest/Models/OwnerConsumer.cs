using GraphQL;
using GraphQL.Client.Abstractions;

namespace GraphQlApitest.Models
{
    //CETTE CLASSE SERVIRA A STOCKER LES QUERIES ET LES MUTATIONS
    public class OwnerConsumer
    {
        private readonly IGraphQLClient _client;

        public OwnerConsumer(IGraphQLClient client)
        {
            _client = client;
        }
        //creation d'une requete grapgql renvoyant tout mles objet de type Owner 
        public async Task<List<Owner>> GetAllOwner ()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                query ownersQuery{

                    owners{
                      id
                      name 
                      address 
                      account{
                               id 
                               type 
                               description 
                             }    
                           }    
                        }"
            };
            //attente de la reposne 
            var response = await _client.SendQueryAsync<ResponseOwnerCollectionType>(query);
            return response.Data.Owners;
        }

        public async Task<Owner> GetOwner(Guid Id)
        {
            var query = new GraphQLRequest {
                Query = @"
                query ownersQuery($ownerID: ID!){

                    owners(ownerId: $ownerID){
                      id
                      name 
                      address 
                      account{
                               id 
                               type 
                               description 
                             }    
                           }    
                        }",
                //permet d'intergrer des parametre dans le querry
                Variables= new {ownerID=Id }
            };
            //attente de la requeste
            var response = await _client.SendQueryAsync<ResponseOwnerType>(query);
            return response.Data.Owner;
        }

        public async Task<Owner> CreateOwner(Ownerinput ownerToCreate)
        {
            var query = new GraphQLRequest
            {
                Query = @"mutation($owner: ownerInput!){ createOwner(owner: $owner){ id,name,address} }",
                //ajout des parametre relatif au querry
                Variables = new {owner=ownerToCreate}
            };

            var response =await _client.SendMutationAsync <ResponseOwnerType>(query);
            return response.Data.Owner;
        }

    }
}
