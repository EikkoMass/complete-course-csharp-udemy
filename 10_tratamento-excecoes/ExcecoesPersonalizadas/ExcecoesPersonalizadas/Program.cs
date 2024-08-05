using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after Check-in date");
                }
                else
                {
                    Reservation reservation = new Reservation(number, checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");

                    Console.WriteLine();

                    Console.WriteLine("Enter data to update the reservation: ");

                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());

                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    DateTime now = DateTime.Now;

                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine($"Reservation: {reservation}");


                }
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in reservation: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            } 
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}");
            }
        }
    }
}
