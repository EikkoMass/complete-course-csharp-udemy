using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace ExercicioFixacao;

public class Program
{
    static void Main(string[] args)
    {
        string source = @"../../../temp/source";
        string target = @"../../../out/summary.csv";
        
        try
        {
            string[] rows = File.ReadAllLines(source);

            using (StreamWriter sw = File.AppendText(target))
            {
                foreach (var row in rows)
                {
                    string[] values = row.Split(',');
                    
                    string name = values[0];
                    double price = double.Parse(values[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(values[2]);
                    
                    sw.WriteLine($"{name},{(price * quantity).ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}