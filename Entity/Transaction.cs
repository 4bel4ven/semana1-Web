using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc.Entity
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get;  }
        public String Notes { get;  }


        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
