namespace ExtensionMethods;

public class Program
{
    static void Main(string[] args)
    {
        // Exemplo1();
        Exemplo2();
    }

    static void Exemplo1()
    {
        DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
    
    static void Exemplo2()
    {
        String s1 = "Good morning dear students";
        Console.WriteLine(s1.Cut(10));
    }
}