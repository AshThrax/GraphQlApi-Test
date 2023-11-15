using Graphql_ASpNetCore_Medium_Tutoriel.Model;

namespace Graphql_ASpNetCore_Medium_Tutoriel.Service
{
    public interface IEmployeeService
    {
        public List<EmployeeDetails> GetEmployeeDetails();
        public List<EmployeeDetails> GetEmployees(int EmpID);
        public List<EmployeeDetails> GetEmployeeBydepartement(int deptid);
    }
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
        }

        private List<Employee> _employee = new List<Employee> 
        { 
            new Employee(1,"Mark",25,1),
            new Employee(1, "Markus", 25, 2),
            new Employee(1, "Bernard", 25, 1),
             new Employee(1, "Toma", 25, 3),
             new Employee(1, "Bryan", 25, 3)
        };
        private List<Departement> _departement = new List<Departement>
        {
            new Departement(1,"IT"),
            new Departement(2,"HR"),
            new Departement(3,"Finanace")
          
        };
        public List<EmployeeDetails> GetEmployeeBydepartement(int deptid)
        {
            return _employee.Where(x => x.DeptId == deptid).Select(emp =>
            new EmployeeDetails
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName = _departement.First(d => d.Id == emp.Id).Name,
            }).ToList();
        }

        public List<EmployeeDetails> GetEmployeeDetails()
        {
            return _employee.Select(emp => new EmployeeDetails 
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName=_departement.First(d=>d.Id==emp.Id).Name,
            }).ToList();
        }

        public List<EmployeeDetails> GetEmployees(int EmpID)
        {
            return _employee.Where(x =>x.Id==EmpID).Select(emp => new EmployeeDetails
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                DeptName = _departement.First(d => d.Id == emp.Id).Name,
            }).ToList();
        }
    }
}
