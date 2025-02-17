using ExercicioFixacao.Entities;

namespace ExercicioFixacao.Services;

public class InstallmentGeneratorService
{
    private readonly IInstallmentProcessingService _installmentProcessingService;

    public InstallmentGeneratorService(IInstallmentProcessingService installmentProcessingService)
    {
        _installmentProcessingService = installmentProcessingService;
    }
    
    public void Generate(Contract contract, int installments)
    {
        double installmentValue = contract.TotalValue / installments;
        for (int installment = 1; installment <= installments; installment++)
        {
            DateOnly date = contract.Date.AddMonths(installment);
            contract.AddInstallment(new Installment(date, _installmentProcessingService.TaxedInstallment(installmentValue, installment)));
        }
    }
}