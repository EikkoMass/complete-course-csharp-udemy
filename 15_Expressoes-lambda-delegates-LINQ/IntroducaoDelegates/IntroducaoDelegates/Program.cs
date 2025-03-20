using IntroducaoDelegates.Services;

namespace IntroducaoDelegates;

delegate double BinaryNumericOperation(double n1, double n2);

public class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
        Console.WriteLine(op(a, b));

        op = CalculationService.Max;
        Console.WriteLine(op(a, b));
        Console.WriteLine(op.Invoke(a, b)); // Mesmo resultado do print acima

        // op = CalculationService.Square; // Invalido! Assinatura da funcao nao bate com a do delegate
    }
}