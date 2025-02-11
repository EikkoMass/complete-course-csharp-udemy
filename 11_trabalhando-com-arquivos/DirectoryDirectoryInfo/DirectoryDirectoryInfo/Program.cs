namespace DirectoryDirectoryInfo;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../temp/myfolder";

        try
        {
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine($"Folders:");
            foreach (var folder in folders) Console.WriteLine(folder);
            
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine($"Files:");
            foreach (var file in files) Console.WriteLine(file);
            
            Directory.CreateDirectory($"{path}/newFolder");
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}