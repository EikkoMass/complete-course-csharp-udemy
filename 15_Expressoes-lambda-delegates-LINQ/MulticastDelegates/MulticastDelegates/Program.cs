using MulticastDelegates.Services;

namespace MulticastDelegates;

delegate void BinaryNumericOperation(double n1, double n2);

public class Program
{
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;
        
        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax; // Delegates podem armazenar multiplas funcoes, rodando todas quando forem chamadas
        
        op(a, b);
        op.Invoke(a, b);
    }
}