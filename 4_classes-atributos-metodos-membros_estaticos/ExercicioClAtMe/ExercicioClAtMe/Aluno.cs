using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClAtMe
{
    internal class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];

        public double CalcularNota() {

            double NotaFinal = 0;

            for (int i = 0; i < Notas.Length; i++)
            {
                NotaFinal += Notas[i];
            }

            return NotaFinal; 
        }
    }
}
