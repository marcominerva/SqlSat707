using System;
using System.Linq;

namespace NetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = NorthwindData.Northwind.LoadEmployeesFromDatabase();
            var results = employees.Select().Select(d => new
            {
                EmployeeId = Convert.ToInt32(d["EmployeeID"]),
                FirstName = d["FirstName"].ToString(),
                LastName = d["LastName"].ToString(),
                Title = d["Title"].ToString()
            });

            foreach (var employee in results)
            {
                Console.WriteLine($"{employee.LastName} {employee.FirstName}");
            }

            Console.ReadLine();
        }
    }
}
