namespace ExercicioPropostoConjuntos;

public class ExercicioPropostoConjuntos
{
    static void Main(string[] args)
    {
        SortedSet<int> students = new SortedSet<int>();
        
        Console.Write("How many students for course A? ");
        int n1 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n1; i++)
        {
            students.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.Write("How many students for course B? ");
        int n2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n2; i++)
        {
            students.Add(int.Parse(Console.ReadLine()));
        }
        
        Console.Write("How many students for course C? ");
        int n3 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n3; i++)
        {
            students.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write($"Total Students: {students.Count}");
    }
}