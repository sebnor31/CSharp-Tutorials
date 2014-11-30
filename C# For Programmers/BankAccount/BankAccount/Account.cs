public class Account
{
   /* Instance variable */
   private decimal balance;

   /* Property */
   public decimal Balance
   {
      get
      {
         return balance;
      } // end get

      set
      {
         if (value > 0)
            balance = value;
      }// end set
   }// end property Balance

   /* Constructor */
   public Account(decimal initialBalance)
   {
      Balance = initialBalance; 
   }// end Constructor

   /* Method */
   public void Credit(decimal amount)
   {
      Balance += amount;
   }// end method Credit

}// end class Account
