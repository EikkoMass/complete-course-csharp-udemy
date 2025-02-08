namespace FileStreamStreamReader;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../temp/file1.txt";
        StreamReader streamReader = null;

        try
        {
            streamReader = File.OpenText(path);
            
            while (!streamReader.EndOfStream)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occured!");
            Console.WriteLine(e.Message);
        }
        finally
        {
            streamReader?.Close();
        }
    }
}