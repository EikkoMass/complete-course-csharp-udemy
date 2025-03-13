namespace DictionarySortedDictionary;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "Maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "99712234";
        cookies["phone"] = "83737388";

        Console.WriteLine(cookies["email"]);
        Console.WriteLine(cookies["phone"]);
        
        cookies.Remove("email");

        Console.WriteLine(cookies.ContainsKey("email") ? cookies["email"] : "There is no 'email' key");
        Console.WriteLine($"Size: {cookies.Count}");

        Console.WriteLine($"All cookies:");
        foreach (KeyValuePair<string, string> cookie in cookies)
        {
            Console.WriteLine($"{cookie.Key}: {cookie.Value}");
        }
    }
}