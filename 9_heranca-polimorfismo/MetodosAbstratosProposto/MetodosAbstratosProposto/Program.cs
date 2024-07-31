using MetodosAbstratosProposto.Entities;
using System.Globalization;
using System.Xml.Linq;

namespace MetodosAbstratosProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int numOfPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPayers; i++)
            {

                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(type == 'C' || type == 'c')
                {
                    Console.Write("Number of employees: ");
                    double numOfEmployees = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new CompanyPayer(name, anualIncome, numOfEmployees));
                } else
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }

                Console.WriteLine();
            }

            Console.WriteLine("TAXED PAID: ");
            double totalTaxes = 0;

            foreach (Payer payer in payers)
            {
                double taxes = payer.PaidTaxes();
                totalTaxes += taxes;
                Console.WriteLine($"{payer.Name}: $ {taxes.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
