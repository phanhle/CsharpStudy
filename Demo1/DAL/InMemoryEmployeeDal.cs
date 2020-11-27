using Demo1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Demo1.DAL
{
    // Implements all accesses to data store
    public class InMemoryEmployeeDal
    {
        // Creates in-memory data store for Employee objects
        private static List<Employee> Employees => new List<Employee> {
            new Employee(){Id = 1, Age = 23, Name="Employee #1", PayRate = 0.2M},
            new Employee(){Id = 2, Age = 24, Name="Employee #2", PayRate = 0.3M},
            new Employee(){Id = 3, Age = 25, Name="Employee #3", PayRate = 0.4M},
            new Employee(){Id = 4, Age = 26, Name="Employee #4", PayRate = 0.5M},
            new Employee(){Id = 5, Age = 27, Name="Employee #5", PayRate = 0.6M}
        };

        public static Employee GetEmployeeById(int id)
        {
            return Employees
                    .Where(emp => emp.Id == id)
                    .FirstOrDefault();
        }
    }
}
