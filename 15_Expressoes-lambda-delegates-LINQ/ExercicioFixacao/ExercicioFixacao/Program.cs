using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using ExercicioFixacao.Entities;

namespace ExercicioFixacao;

public class ExercicioFixacao
{
    static void Main(string[] args)
    {
        List<People> people = new();
        
        Console.Write("Enter full file path: ");
        string filePath = Console.ReadLine();

        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        using (StreamReader reader = File.OpenText(filePath))
        {
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(',');
                
                people.Add(new People(line[0], line[1], double.Parse(line[2], CultureInfo.InvariantCulture)));
            }
        }

        Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}:");
        foreach (var person in people.Where(p => p.Salary > salary))
        {
            Console.WriteLine(person.Email);
        }
        
        Console.WriteLine($"Sum of salary of people whose name starts with 'M': {people.Where(p => p.Name[0] == 'M').Sum(p => p.Salary).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}