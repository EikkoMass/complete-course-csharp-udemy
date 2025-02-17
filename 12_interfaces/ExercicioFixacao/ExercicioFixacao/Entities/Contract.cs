using System.Globalization;

namespace ExercicioFixacao.Entities;

public class Contract
{
    public int Number { get; private set; }
    public DateOnly Date { get; private set; }
    public double TotalValue { get; private set; }
    private List<Installment> Installments;
    
    public Contract(int number, DateOnly date, double totalValue)
    {
        Number = number;
        Date = date;
        TotalValue = totalValue;
        Installments = new List<Installment>();
    }

    public void AddInstallment(Installment installment)
    {
        Installments.Add(installment);
    }

    public override string ToString()
    {
        string installmentList = String.Empty;

        foreach (Installment installment in Installments)
        {
            installmentList += $"{installment.DueDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)} - {installment.Amount.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }

        return installmentList;
    }
}