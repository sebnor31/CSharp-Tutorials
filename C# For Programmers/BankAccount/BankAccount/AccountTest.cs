using System;

class AccountTest
{
   static void Main()
   {
      Account account1 = new Account(50.00M);
      Account account2 = new Account(-7.53M);

      Console.WriteLine("account1 balance: {0:C}", account1.Balance);
      Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

      decimal depositAmount;

      Console.Write("Enter Deposit amount for account1: ");
      depositAmount = Convert.ToDecimal(Console.ReadLine());
      Console.WriteLine("Adding {0:C} to account1 balance\n", depositAmount);
      account1.Credit(depositAmount);

      Console.WriteLine("account1 balance: {0:C}", account1.Balance);
      Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);

      Console.ReadLine();
   }
}

