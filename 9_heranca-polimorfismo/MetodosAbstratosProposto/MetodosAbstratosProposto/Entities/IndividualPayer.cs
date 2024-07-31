namespace MetodosAbstratosProposto.Entities
{
    internal class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double PaidTaxes()
        {
            return (AnualIncome * (AnualIncome < 20000 ? 0.15 : 0.25)) - (HealthExpenditures * 0.5);
        }
    }
}
