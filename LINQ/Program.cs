using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static List<Department> GetDepartments()
    {
        // Simulated data for demonstration
        List<Department> departments = new List<Department>
        {
            new Department
            {
                Employees = new List<Employee>
                {
                    new Employee { Name = "John", Id = 1 },
                    new Employee { Name = "Alice", Id = 2 }
                }
            },
            new Department
            {
                Employees = new List<Employee>
                {
                    new Employee { Name = "Bob", Id = 3 },
                    new Employee { Name = "Emma", Id = 4 }
                }
            }
        };
        return departments;
    }

    public static void Main(string[] args)
    {
        var employees = GetDepartments()
            .SelectMany(dept => dept.Employees)
            .ToList();

        // Displaying the result
        Console.WriteLine("Employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}, ID: {employee.Id}");
        }
    }
}
