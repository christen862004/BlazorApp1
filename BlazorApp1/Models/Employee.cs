namespace BlazorApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public int DeptartmentId { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\t-\t Address:{Address}\t-\t Salary:{Salary}\t-\t DepartementID:{DeptartmentId}";
        }
    }
}
