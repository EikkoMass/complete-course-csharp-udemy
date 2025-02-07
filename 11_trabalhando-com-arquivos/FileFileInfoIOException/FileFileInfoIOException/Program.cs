namespace FileFileInfoIOException;

public class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"../../../temp/file1.txt";
        string targetPath = @"../../../temp/file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An Error occured!");
            Console.WriteLine(e.Message);
        }
    }
}