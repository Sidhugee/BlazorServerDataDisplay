using Microsoft.AspNetCore.Components;
using static Microsoft.AspNetCore.Components.NavigationManager;

namespace BlazorApp1.Data
{
    public class EmployeeService : ComponentBase
        // Component Base is used when i want to use the base component like OnInitializedAsync, OnParameter etc
    {
      
      
        //1:Ist i make the get method to load data in razor page
        public IEnumerable <Employee> Employees { get; set; }

        public List<Employee> GetuniqueSearch( string firstname, NavigationManager navigationManager)
        {
            return Employees.Where(x => x.FirstName == firstname).ToList();

        }
        //4: Then I initialize it coz the base controller is used for initializing the database on browser for better user interaction
        protected override async Task OnInitializedAsync()
        {
          await Task.Run(LoadEmployees);

        }
        //2:Second i make a LoadEmployes function that seed some data in Employees list
        public void LoadEmployees()
        {
            //5: Then i use a thread statment to load employees and sleep for 3000ms.
            System.Threading.Thread.Sleep(3000);
           Employee e1 =  new Employee()
            { EmployeeId = 1,
                FirstName = "Sallal",
                LastName = "Haider",
                DAteOfBirth = new DateTime(1980,10,5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "IT" } };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Haider",
                LastName = "Ali",
                DAteOfBirth = new DateTime(1981, 11, 6),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 2, DepartmentName = "IT" }
            };
            //3:Third store this data to make a list if array
            Employees = new List<Employee> {e1, e2 };
        }
            
        }

    }

