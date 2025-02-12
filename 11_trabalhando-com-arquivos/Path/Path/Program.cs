namespace Path;

public class Program
{
    static void Main(string[] args)
    {
        string path = @"../../../temp/myfolder/file1.txt";
        
        Console.WriteLine($"DirectorySeparatorChar: {System.IO.Path.DirectorySeparatorChar}");
        Console.WriteLine($"PathSeparator: {System.IO.Path.PathSeparator}");
        Console.WriteLine($"GetDirectoryName: {System.IO.Path.GetDirectoryName(path)}");
        Console.WriteLine($"GetFileName: {System.IO.Path.GetFileName(path)}");
        Console.WriteLine($"GetExtension: {System.IO.Path.GetExtension(path)}");
        Console.WriteLine($"GetFileNameWithoutExtension: {System.IO.Path.GetFileNameWithoutExtension(path)}");
        Console.WriteLine($"GetFullPath: {System.IO.Path.GetFullPath(path)}");
        Console.WriteLine($"GetTempPath: {System.IO.Path.GetTempPath()}");
    }
}