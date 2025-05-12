using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class DepartmentComponent
    {
        public List<Department> DeptList { get; set; }
        //property
        public Department Dept { get; set; }

        public int DeptID { get; set; } //Selected DEpartment ID


        public DepartmentComponent()
        {
            //Dept=new Department() { Id=1,Name="SD",ManagerName="Ahemd"};
            DeptList = new List<Department>() { 
                new (){ Id=1,Name="SD",ManagerName="Ahemd"},
                new (){ Id=2,Name="OS",ManagerName="Sara"},
                new (){ Id=3,Name="GIS",ManagerName="Mohamed"},
                new (){ Id=4,Name="UI",ManagerName="Hassan"},
                new (){ Id=5,Name="Digital Marketing",ManagerName="Esraa"},
            };
        }

        public void GetDepartment()
        {
            Dept = DeptList.FirstOrDefault(d=>d.Id== DeptID);
        }
    }
}
