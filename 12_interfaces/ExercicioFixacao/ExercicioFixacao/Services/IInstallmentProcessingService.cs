namespace ExercicioFixacao.Services;

public interface IInstallmentProcessingService
{
    public double TaxedInstallment(double installmentValue, int installment);
}