using GraphQL.Types;

namespace Graphql_ASpNetCore_Medium_Tutoriel.Model
{
   public record Employee(int Id, string Name, int Age, int DeptId);

    public record Departement(int Id,string Name);

    public class EmployeeDetails
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string DeptName { get; set; }
    }

    public class EmployeeDetailsType : ObjectGraphType<EmployeeDetails>
    {
        public EmployeeDetailsType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.DeptName);
        }
    }

}
