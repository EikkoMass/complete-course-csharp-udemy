using System;


namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantRooms = 10;

            Console.Write("How many rooms will be rented? ");
            int quantRents = int.Parse(Console.ReadLine());

            Room[] rooms = new Room[quantRooms];

            for (int i = 0; i < quantRents; i++) {

                Console.WriteLine();
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int number = int.Parse(Console.ReadLine());

                rooms[number] = new Room(name, email, number);
            }

            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < quantRooms; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }
        }
    }
}