namespace ExercicioFixacao.Services;

public class ContractInstallmentProcessingService : IInstallmentProcessingService
{
    public double MonthlyPercentage { get; private set; }
    public double PaymentFeePercentage { get; private set; }

    public ContractInstallmentProcessingService(int monthlyPercentage, int paymentFeePercentage)
    {
        MonthlyPercentage = monthlyPercentage * 0.01;
        PaymentFeePercentage = paymentFeePercentage * 0.01;
    }
    
    public double TaxedInstallment(double installmentValue, int installment)
    {
        var value = installmentValue + (installmentValue * MonthlyPercentage * installment);
        value += value * PaymentFeePercentage;
        
        return value;
    }
}