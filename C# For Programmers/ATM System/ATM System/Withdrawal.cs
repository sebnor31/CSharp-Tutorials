using System;

public class Withdrawal : Transaction
{
   /* Attributes */
   private decimal amount;                // amount to withdraw
   private Keypad keypad;                 // reference to the keypad
   private CashDispenser cashDispenser;   // reference to the cash dispenser

   /* Constructor */
   public Withdrawal()
   { }//end constructor Withdrawal

   /* Methods */
   public override void Execute()
   { }//end method Execute

}//end class Withdrawal

