
namespace MetodosAbstratosProposto.Entities
{
    class CompanyPayer : Payer
    {
        public double NumOfEmployees { get; set; }

        public CompanyPayer(string name, double anualIncome, double numOfEmployees) : base(name, anualIncome)
        {
            NumOfEmployees = numOfEmployees;
        }

        public override double PaidTaxes()
        {
            return AnualIncome * (NumOfEmployees > 10 ? 0.14 : 0.16);
        }
    }
}
