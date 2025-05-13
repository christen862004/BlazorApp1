using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class DepartmentService : IServices<Department>
    {
        List<Department> Departments;
        public DepartmentService()
        {
            Departments = new() {
                new(){Id=1,Name="SD",ManagerName="ahmed"},
                new(){Id=2,Name="GIS",ManagerName="ahmed"},
                new(){Id=3,Name="Os",ManagerName="ahmed"},
            };
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Department obj)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAll()
        {
            return Departments;
        }

        public Department GetByID(int id)
        {
            return Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Insert(Department obj)
        {
            throw new NotImplementedException();
        }
    }
}
