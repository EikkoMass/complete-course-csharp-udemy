namespace ExercicioPropostoHeranPoli.Entidades
{
    class UsedProduct : Product
    {
        private DateOnly ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateOnly manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("N2")} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
