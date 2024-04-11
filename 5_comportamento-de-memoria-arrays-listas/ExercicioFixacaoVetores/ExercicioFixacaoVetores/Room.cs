using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoVetores
{
    internal class Room
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number {  get; set; }

        public Room() { }

        public Room(string name, string email, int number) {

            Name = name;
            Email = email;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Number}: {Name}, {Email}";
        }
    }
}
