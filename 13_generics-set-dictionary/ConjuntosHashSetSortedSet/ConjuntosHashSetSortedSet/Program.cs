namespace ConjuntosHashSetSortedSet;

public class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        
        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Notebook"));
        Console.WriteLine(set.Contains("Computer"));

        foreach (string p in set)
        {
            Console.WriteLine(p);
        }
    }
}