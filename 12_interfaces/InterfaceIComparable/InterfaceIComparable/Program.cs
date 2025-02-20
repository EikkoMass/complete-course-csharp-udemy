using InterfaceIComparable.Entities;

namespace InterfaceIComparable;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../temp/in.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> lines = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    lines.Add(new Employee(sr.ReadLine()!));
                }
                
                lines.Sort();
                
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}