using ExercicioFixacaoExcecao.Entities.Exceptions;

namespace ExercicioFixacaoExcecao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = 0;
            WithdrawLimit = withdrawLimit;
        }

        public void  Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw (double value)
        {

            if (value > WithdrawLimit)
            {
                throw new WithdrawLimitException("The amount exceeds withdraw limit");
            }

            if (value > Balance)
            {
                throw new WithdrawLimitException("Not enough balance");
            }

            Balance -= value;
        }
    }
}
