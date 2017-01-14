using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoaster
{
    public class Employee
    {
        public string name;
        public int age;
        public decimal salary;
        public string position;
        public string department;
        public string email;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<Employee>();
            HashSet<string> departments = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                var empo = new Employee(name, salary, position, department);
               
                if (input.Length == 5 && input[4].Contains("@"))
                {
                    empo.email = input[4];
                   
                }
                else if (input.Length == 5 && !input[4].Contains("@"))
                {
                    empo.age = int.Parse(input[4]);
                }
                if (input.Length == 6)
                {
                    empo.email = input[4];
                    empo.age = int.Parse(input[5]);
                }
                list.Add(empo);
                departments.Add(department);
            }
            var result = list.GroupBy(e => e.department).Select(
                e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(s => s.salary),
                    Employ = e.OrderByDescending(s => s.salary)
                }).ToList();
            string maxDep = string.Empty;

            decimal maxSalary = 0;

            foreach (var item in departments)
            {
                int count = 0;
                decimal sum = 0;
                foreach (var e in list)
                {
                    if (e.department == item)
                    {
                        count++;
                        sum += e.salary;
                    }
                }
                sum /= count;
                if (sum >= maxSalary)
                {
                    maxSalary = sum;
                    maxDep = item;
                }
            }
            Console.WriteLine($"Highest Average Salary: {maxDep}");
            list = list.Where(e => e.department == maxDep).OrderByDescending(e => e.salary).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.name} {item.salary:F2} {item.email} {item.age}");
            }
        }
    }
}
