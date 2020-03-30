using BankAppUpc.Common;
using BankAppUpc.Entity;
using System;

namespace BankAppUpc
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Henry Mendoza Puerta", 1000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} " +
                $"with  {account.Balance} initial balance");


            //Retiro
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);

            //Deposito
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            var product = new Product
            {
                Id=1,
                Name="Electric Guitar",
                Status=Enums.Status.Disabled
            };

           // if(product.Status==Enums.Status.Disabled || product.Status== Enums.Status.Pending)
           //if(ValidationHelper.ProductPendingOrDisabled(product.Status)
           // {
           //     Console.WriteLine($"The current product is {product.Status}");
           // }
        }
    }
}
