using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using SoftUniContext context = new SoftUniContext();
            string result = GetDepartmentsWithMoreThan5Employees(context);
            Console.WriteLine(result);
        }

        // Problem 3

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new  {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        // Problem 4

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        // Problem 5

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    DepartmentName = e.Department.Name
                })
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
            }

            return result.ToString().TrimEnd();
        }

        // Problem 6

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Employee nakov = context.Employees
                .First(e => e.LastName == "Nakov");
            Address newAddres = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            nakov.Address = newAddres;

            context.SaveChanges();

            var employeesAddresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, employeesAddresses);
        }

        // Problem 7 

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    EmployeeFirstName = e.FirstName,
                    EmployeeLastName = e.LastName,
                    ManagerFirstName = e.Manager == null ? null : e.Manager.FirstName,
                    ManagerLastName = e.Manager == null ? null : e.Manager.LastName,
                    Projects = e.EmployeesProjects
                    .Select(ep => ep.Project)
                    .Where(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003)
                    .Select(p => new
                    {
                        ProjectName = p.Name,
                        p.StartDate,
                        p.EndDate
                    })
                    .ToArray()
                })
                .Take(10)
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.EmployeeFirstName} {e.EmployeeLastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");

                foreach (var p in e.Projects)
                {
                    string startDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt");
                    string endDate;
                    if (p.EndDate.HasValue)
                    {
                        endDate = p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt");
                    }
                    else
                    {
                        endDate = "not finished";
                    }
                        
                    result.AppendLine($"--{p.ProjectName} - {startDate} - {endDate}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // Problem 8

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var result = new StringBuilder();

            var addresses = context.Addresses
                .Select(a => new
                {
                    a.AddressText,
                    Town = a.Town.Name,
                    EmployeeCount = a.Employees.Count()
                })
                .OrderByDescending(a => a.EmployeeCount)
                .ThenBy(a => a.Town)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .ToArray();

            foreach ( var a in addresses)
            {
                result.AppendLine($"{a.AddressText}, {a.Town} - {a.EmployeeCount} employees");
            }

            return result.ToString().TrimEnd();
        }

        // Problem 9

        public static string GetEmployee147(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeesProjects
                    .OrderBy(p => p.Project.Name)
                    .Select(p => p.Project.Name)                    
                    .ToArray()
                })
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");

                foreach (var project in e.Projects)
                {
                    result.AppendLine($"{project}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // Problem 10

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var result = new StringBuilder();

            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    d.Name,
                    d.Manager.FirstName,
                    d.Manager.LastName,
                    Employees = d.Employees
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle
                        })
                        .ToArray()
                })
                .ToArray();

            foreach (var d in departments)
            {
                result.AppendLine($"{d.Name} – {d.FirstName} {d.LastName}");

                foreach (var e in d.Employees)
                {
                    result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }
            }

            return result.ToString().TrimEnd();
        }

        // Problem 11

        public static string GetLatestProjects(SoftUniContext context)
        {
            var result = new StringBuilder();

            var lastProjects = context.Projects
                .OrderByDescending(p => p.StartDate) 
                .Select(p => new 
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .Take(10)
                .ToArray();

            lastProjects = lastProjects
                .OrderBy(lp => lp.Name)
                .ToArray();

            foreach (var project in lastProjects)
            {
                result.AppendLine($"{project.Name}");
                result.AppendLine(project.Description);
                result.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
            }

            return result.ToString().TrimEnd();
        }

        // Problem 12

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering"
                || e.Department.Name == "Tool Design"
                || e.Department.Name == "Marketing"
                || e.Department.Name == "Information Services")
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();
                     
            foreach (var e in employees) 
            {
                e.Salary *= 1.12m;
            }

            context.SaveChanges();

            foreach (var e in employees)
            {                
                result.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }

            return result.ToString().TrimEnd();
                
        }

        // Problem 13

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Select(e => new 
                { 
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return result.ToString().TrimEnd();
        }

        // Problem 14

        public static string DeleteProjectById(SoftUniContext context)
        {
            const int deleteProjectId = 2;

            var employeesProjectsDelete = context.EmployeesProjects
                .Where(ep => ep.ProjectId == deleteProjectId)
                .ToArray();

            context.EmployeesProjects.RemoveRange(employeesProjectsDelete);

            Project? deleteProject = context.Projects
                .Find(deleteProjectId);

            if ( deleteProject != null)
            {
                context.Projects.Remove(deleteProject);
            }

            var projectNames = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, projectNames);
        }

        // Problem 15

        public static string RemoveTown(SoftUniContext context)
        {
            const string townToDelete = "Seattle";
            int countAddresesDeleted = 0;

            var employeesToNull = context.Employees
                .Where(e => e.Address.Town.Name == townToDelete)
                .ToArray();
            foreach (var e in employeesToNull)
            {
                e.AddressId = null;
            }

            var addressesToDelete = context.Addresses
                .Where(a => a.Town.Name == townToDelete)
                .ToArray();
            countAddresesDeleted = addressesToDelete.Length;
            context.Addresses.RemoveRange(addressesToDelete);

            Town deleteTown = context.Towns
                .First(t => t.Name == townToDelete);
            context.Towns.Remove(deleteTown);

            context.SaveChanges();

            return $"{countAddresesDeleted} addresses in Seattle were deleted";
        }
    }
}
