using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc.Entity
{
    public class BankAccount
    {
        public string Number { get;  }

        public string Owner { get; set; }

        private List<Transaction> transactions = new List<Transaction>();

        private static int accountNumberSeed = 1234567890;

        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach(var item in transactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date,string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            transactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withrdrawal must be positive");
            }
            if(Balance-amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for thus withrdrawal");
            }
            var withrdrawal = new Transaction(-amount, date, note);
            transactions.Add(withrdrawal);
        }

    }
}
