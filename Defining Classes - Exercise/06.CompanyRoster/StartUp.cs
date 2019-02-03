namespace _06.CompanyRoster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employes = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                var salary = double.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var email = input.Length>4 ? input[4].Contains("@")? input[4]: "n/a" : "n/a";
                var age = input.Length > 4 ? !input[4].Contains("@") ? int.Parse(input[4]) : -1 : -1;
                age = input.Length > 5 ? int.Parse(input[5]):age;

                var employee = new Employee(name,salary,position,department,email,age);
                employes.Add(employee);
            }

            var departmentWithHighAverageSalary = employes.GroupBy(x => x.Department)
                .OrderByDescending(y=>y.Select(s=>s.Salary).Average())
                .FirstOrDefault()
                .Key;
                

            Console.WriteLine($"Highest Average Salary: {departmentWithHighAverageSalary}");

            foreach (var employee in employes.Where(x => x.Department == departmentWithHighAverageSalary).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
