using GraphQL;
using GraphQL.Types;
using Graphql_ASpNetCore_Medium_Tutoriel.Model;
using Graphql_ASpNetCore_Medium_Tutoriel.Service;

namespace Graphql_ASpNetCore_Medium_Tutoriel.GraphQl
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployeeService employeeService)
        {
            Field<ListGraphType<EmployeeDetailsType>>(Name = "Employee",resolve: x => employeeService.GetEmployees());
            Field<ListGraphType<EmployeeDetailsType>>(Name = "Employee",arguments: new QueryArguments<IntGraphType> {Name="Id" },
                resolve: x=>employeeService.GetEmployees(x.GetArgument<int>("id"))
                );
        }
    }
    public class EmployeeDetailsSchema : Schema
    {
        public EmployeeDetailsSchema(IServiceProvider serviceProvider):base(serviceProvider) 
        { 
            Query=serviceProvider.GetRequiredService<EmployeeQuery>();
        }
    }
}
