using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_6
{
    public class Employee
    { 
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Employee(string name, string position, string department, decimal salary)
        {
            this.Name = name;
            this.Position = position;
            this.Department = department;
            this.Salary = salary;
            this.Email = "N/A";
            this.Age = -1;
        }
    }

    public class Department
    {
        public string nameOfDepartment;
        public List<Employee> people;

        public Department(string name)
        {
            this.nameOfDepartment = name;
            this.people = new List<Employee>();
        }

        public Department()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of employees: ");
            int amountOfEmployee = int.Parse(Console.ReadLine());

            string employeeName;
            decimal salary;
            string position;
            string departmentName;

            var department = new List<Department>();

            for (int i = 0; i < amountOfEmployee; i++)
            {
                var employees = Console.ReadLine().Split();
                employeeName = employees[0];
                salary = decimal.Parse(employees[1]);
                position = employees[2];
                departmentName = employees[3];

                if (!department.Any(j => j.nameOfDepartment == departmentName))
                {
                    var currentDepartment = new Department(departmentName);
                    department.Add(currentDepartment);
                }

                if(!department.Any(w => w.people.Any(e => e.Name == employeeName)))
                {
                    var oneEmployee = new Employee(employeeName, position, departmentName, salary);
                    if (employees.Length == 6)
                    {
                        oneEmployee.Email = employees[4];
                        oneEmployee.Age = int.Parse(employees[5]);
                    } 
                    else if (employees.Length == 5)
                    {
                        if (employees[4].Contains("@"))
                        {
                            oneEmployee.Email = employees[4];
                        }
                        else
                        {
                            oneEmployee.Age = int.Parse(employees[4]);
                        }
                    }

                    department.FirstOrDefault(d => d.nameOfDepartment == departmentName).people.Add(oneEmployee);
                }
            }

            Department forDepartment =
                department
                    .OrderByDescending(d => d.people.Average(e => e.Salary))
                    .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {forDepartment.nameOfDepartment}");

            foreach (var employee in forDepartment.people.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
