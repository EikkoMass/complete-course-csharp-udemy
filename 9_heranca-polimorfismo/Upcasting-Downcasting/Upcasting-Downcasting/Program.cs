﻿using Upcasting_Downcasting.Entities;

namespace Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100);
            // acc2.Loan(100);

            // Erro de casting
            // BusinessAccount acc5 = (BusinessAccount) acc3;

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }
        
            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount) acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }

        }
    }
}
