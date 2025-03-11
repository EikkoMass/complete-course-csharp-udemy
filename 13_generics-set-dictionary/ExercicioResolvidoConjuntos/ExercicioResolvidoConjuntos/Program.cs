using System.Globalization;
using ExercicioResolvidoConjuntos.Entities;

namespace ExercicioResolvidoConjuntos;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter file full path: ");
            string filePath = Console.ReadLine();
            HashSet<User> users = new HashSet<User>();
            
            if (!String.IsNullOrEmpty(filePath))
            {
                var lines = File.ReadLines(filePath);
                
                foreach (var line in lines)
                {
                    string[] data = line.Split(' ');
                    users.Add(new User(data[0], DateTime.Parse(data[1])));
                }

                Console.WriteLine($"Total Users : {users.Count}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}