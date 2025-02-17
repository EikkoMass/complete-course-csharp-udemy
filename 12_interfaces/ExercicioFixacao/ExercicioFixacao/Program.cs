using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;

namespace ExercicioFixacao;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("Date (dd/MM/yyyy): ");
        DateOnly date = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Enter number of installments: ");
        int numberOfInstallments = int.Parse(Console.ReadLine());
        
        Contract contract = new Contract(number, date, contractValue);
        InstallmentGeneratorService service = new InstallmentGeneratorService(new ContractInstallmentProcessingService(1, 2));
        
        service.Generate(contract, numberOfInstallments);
        
        Console.WriteLine(contract);
    }
}