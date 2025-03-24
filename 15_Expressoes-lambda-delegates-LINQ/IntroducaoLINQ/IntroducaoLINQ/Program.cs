namespace IntroducaoLINQ;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 4, 5 };
        
        IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);

        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}