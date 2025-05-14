using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Is Requird")]
        [MinLength(3)]
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        [Range(7000,25000)]
        public int Salary { get; set; }

        public int DeptartmentId { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\t-\t Address:{Address}\t-\t Salary:{Salary}\t-\t DepartementID:{DeptartmentId}";
        }
    }
}
