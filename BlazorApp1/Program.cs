using BlazorApp1.Models;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");//index.html ==>wwwroot
            builder.RootComponents.Add<HeadOutlet>("head::after");
            //built in Compoennt Change titile per PageComponent

            //day 3
            //Register cusomt service
            builder.Services.AddScoped<IServices<Employee>, EmployeeService>();
            builder.Services.AddScoped<IServices<Department>, DepartmentService>();


            //Buil in service need to register
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
