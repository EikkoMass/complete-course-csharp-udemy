using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoHeranPoli.Entidades
{
    class ImportedProduct : Product
    {
        private double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price) { 
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("N2")} (Custom Fee: $ {CustomFee.ToString("N2")})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
