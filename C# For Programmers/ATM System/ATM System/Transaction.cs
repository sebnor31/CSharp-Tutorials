using System;

public abstract class Transaction
{
   /*** Instance Variable ***/
   private int accountNumber;       // indicates account involved
   private Screen userScreen;       // ATM's screen
   private BankDatabase database;   // account info database

   /*** Constructor ***/
   public Transaction()
   {
   }//end constructor Transaction


   /*** Property (Read-Only) ***/
   public int AccountNumber
   {
      get {return accountNumber; }
   }//end property AccountNumber

   public Screen UserScreen
   {
      get { return userScreen; }
   }//end property UserScreen

   public BankDatabase Database
   {
      get { return database; }
   }//end property Database


   /*** Methods ***/
   public abstract void Execute();

}//end class Transaction

