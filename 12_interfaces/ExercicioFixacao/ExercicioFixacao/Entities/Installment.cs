namespace ExercicioFixacao.Entities;

public class Installment
{
    public DateOnly DueDate { get; private set; }
    public double Amount { get; private set; }

    public Installment(DateOnly dueDate, double amount)
    {
        DueDate = dueDate;
        Amount = amount;
    }
}