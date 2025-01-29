using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double CotacaoDolar;

        public static double ValorASerPago(double dolares)
        {
            double valueToBuy = dolares * CotacaoDolar;

            return valueToBuy + (valueToBuy * 0.06);
        }


    }
}
