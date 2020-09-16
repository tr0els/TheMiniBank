using System;

namespace MiniBank.Core.Entities
{
    public class BankAccount
    {
        public int id { get; set; }
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double ActualBalance { get; set; }
        public List<Transaction> GetAllTransactions { get; }
        public List<Customer> GetAllCusmtomers { get; }
    }
}
