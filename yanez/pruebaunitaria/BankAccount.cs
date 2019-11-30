using System;

namespace pruebaunitaria
    

{
    internal class BankAccount
    {
        private string v;
        private double beginningBalance;

        public BankAccount(string v, double beginningBalance)
        {
            this.v = v;
            this.beginningBalance = beginningBalance;
        }

        public double Balance { get; internal set; }

        internal void Debit(double debitAmount)
        {
            throw new NotImplementedException();
        }
    }
}