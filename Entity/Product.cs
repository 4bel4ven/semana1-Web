using BankAppUpc.Common;
using System;
using System.Collections.Generic;
using System.Text;


namespace BankAppUpc.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Enums.Status Status { get; set; }
    }
}
