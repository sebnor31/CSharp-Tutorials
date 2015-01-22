/* Read-only instance variables are used to avoid modification of their values after the constructor is called.
 * They differ from CONST as the latter requires initialization of the constant during compilation (a value has to be given when declared),
 * whereas read-only enables the variable to be initialized during run-time inside the constructor.
 * Therefore, a more complex initialization can be carried out whereas CONST only enables simple types (string, int, etc.).
 * 
 * As with constants, the convention is to capitalize the variable name.
 */

using System;

public class IncrementTest
{
   public static void Main()
   {
      /* Creat an increment object with increment step of 5 */
      Increment incrementer = new Increment(5);

      /* Show the vlaue of total before incrementation */
      Console.WriteLine("Before incrementing: {0}\n", incrementer);

      /* Increment total  */
      for (int i = 1; i <= 3; i++)
      {
         incrementer.AddIncrementToTotal();
         Console.WriteLine("After increment {0}: {1}\n", i, incrementer);
      }// end for

      Console.ReadLine();
   }// end method Main

}// end class Increment

public class Increment
{
   /* Instance variables */ 
   private readonly int INCREMENT;  // Uninitialized read-only variable 
   private int total = 0;

   /* Constructor */
   public Increment(int incrementValue)
   {
      INCREMENT = incrementValue;      // Initialize read-only variable
   }// end constructor Increment

   /* Methods */
 
   // Add increment to total
   public void AddIncrementToTotal()
   {
      total += INCREMENT;
   }// end method AddIncrementToTotal

   // Return string representation of an Increment object's data
   public override string ToString()
   {
      return string.Format("total = {0}", total);
   }// end method ToString

}// end class Increment

