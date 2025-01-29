using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioFixacaoListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int quantNewEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 0; i < quantNewEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(x => x.Id == employeeId);

            if(employee == null)
            {
                Console.WriteLine("This id not exist!");
                ShowEmployeeList(employees);
                return;
            }

            Console.WriteLine();
            Console.Write("Enter the percentage: ");
            employee.IncreaseSalary(int.Parse(Console.ReadLine()));

            ShowEmployeeList(employees);
        }

        public static void ShowEmployeeList(List<Employee> employees)
        {
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
