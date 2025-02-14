using System.Globalization;

namespace SolucaoSemInterface.Entities;

public class Invoice
{
    public double BasicPayment;
    public double Tax;

    public Invoice(double basicPayment, double tax)
    {
        BasicPayment = basicPayment;
        Tax = tax;
    }

    public double TotalPayment => BasicPayment + Tax;

    public override string ToString()
    {
        return 
            @$"Basic Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n
            Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n
            Total Payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}