using System;

class Program
{
   static void Main(string[] args)
   {
      int years = 10;
      double interest = 0.05;
      decimal balance = 1000;

      Console.WriteLine("{0}{1,20}", "Year", "Amount on deposit");

      for(int i = 1 ; i <= years ; i++ )
      {
         balance *= (decimal) (1 + interest);
         Console.WriteLine("{0,4}{1,20:C}", i, balance);
      }
      
      Console.ReadLine();
   }
}

