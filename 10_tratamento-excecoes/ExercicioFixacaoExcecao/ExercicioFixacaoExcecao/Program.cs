using ExercicioFixacaoExcecao.Entities;
using ExercicioFixacaoExcecao.Entities.Exceptions;
using System.Globalization;

namespace ExercicioFixacaoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, withdrawLimit);
                account.Deposit(balance);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.Write($"New Balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

            }
            catch (WithdrawLimitException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}
