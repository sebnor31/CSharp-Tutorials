using System;

public class Account
{
   /* Attributes */
   private int accountNumber;
   private int pin;
   private decimal availableBalance;
   private decimal totalBalance;

   /* Properties */
   public decimal AvailableBalance
   {
      get { return availableBalance; }
   }

   public decimal TotalBalance
   {
      get { return totalBalance; }
   }

   /* Constructor */
   public Account()
   { }//end constructor Account

   /* Methods */
   public bool ValidatePIN()
   { return false; }//end method ValidatePIN

   public void Credit()
   { }//end method Credit

   public void Debit()
   { }//end method Debit

}//end class Account

