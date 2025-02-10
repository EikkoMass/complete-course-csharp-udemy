namespace StreamWriter;

public class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"../../../temp/file1.txt";
        string targetPath = @"../../../temp/file2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (System.IO.StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines) sw.WriteLine(line.ToUpper());
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occured!");
            Console.WriteLine(e.Message);
        }
    }
}