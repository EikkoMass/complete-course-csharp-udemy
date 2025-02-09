namespace BlocoUsing;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../temp/file1.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
    }
}