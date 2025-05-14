using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp1.Pages.EmpPages
{
    public partial class EmpEditComponent
    {
        [Parameter]
        public int id { get; set; }

        [Inject]
        public IServices<Employee> EmpService { get; set; }
        
        [Inject]
        public NavigationManager NavManagger { get; set; }//built in service s,already register in sefvice provider

        [Inject]
        public IServices<Department> DeptService { get; set; }

        public Employee EmpObj { get; set; }

        public List<Department> DeptList { get; set; }

        
        protected override void OnInitialized()
        {
            EmpObj = EmpService.GetByID(id);

            DeptList=DeptService.GetAll();

            base.OnInitialized();
        }

        public void Save()
        {
            
            //call web api Edit Model
            Console.WriteLine("Save Submit Success");
            NavManagger.NavigateTo("/Emps");
        }


        public void NoSave()
        {
            Console.WriteLine("Inavlid Modedl");
        }
    }
}
