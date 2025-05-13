using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class EmployeeService : IServices<Employee>
    {
        List<Employee> Employees;
        public EmployeeService()
        {
            Employees = new() { 
                new Employee(){Id=1,Name="Ahmed",Address="Alex",Salary=10000,DeptartmentId=1},
                new Employee(){Id=2,Name="Mohmade",Address="Alex",Salary=10000,DeptartmentId=2},
                new Employee(){Id=3,Name="Sara",Address="Alex",Salary=10000,DeptartmentId=3},
                new Employee(){Id=4,Name="Mariam",Address="Alex",Salary=10000,DeptartmentId=1},
                new Employee(){Id=5,Name="Ali",Address="Alex",Salary=10000,DeptartmentId=2},
                new Employee(){Id=6,Name="Basma",Address="Alex",Salary=10000,DeptartmentId=3},
            };
        }
        public void Delete(int id)
        {
            Employees.Remove(GetByID(id));
        }

        public void Edit(int id, Employee obj)
        {
            Employee orgEmp = GetByID(id);
            orgEmp.Name = obj.Name;
            orgEmp.Address = obj.Name;
            //orgEmp. = obj.Name;
            //orgEmp.Name = obj.Name;
            //orgEmp.Name = obj.Name;
        }

        public List<Employee> GetAll()
        {
            return Employees;
        }

        public Employee GetByID(int id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Employee obj)
        {
            Employees.Add(obj);
        }
    }
}
