using System;

public class RefAndOutParam
{
   int y = 5;     // Initialzed
   int z;         // Uninitialized

   public void DemonstrateRefAndOutParam() 
   {
      Console.WriteLine("Original value of y: {0}", y);
      Console.WriteLine("Original value of z: {0}", z);

      /* Pass arguments by reference */
      SquareRef(ref y);    // Use ref as y already initialized
      Console.WriteLine("Value after reference of y: {0}", y);

      SquareOut(out z);    // Use out as z not already initialized
      Console.WriteLine("Value after reference of z: {0}", z);

      /* Pass arguments by value */
      SquareInt(y);
      Console.WriteLine("Value after passed by value of y: {0}", y);

      SquareInt(z);
      Console.WriteLine("Value after passed by value of z: {0}", z);

   }// end method DemonstrateRefAndOutParam

   /* Use reference parameter x to modify caller's variable */
   private void SquareRef(ref int x)
   {
      x = x * x;
   }// end method SquareRef

   /* Use output parameter x to assign a value to an uninitialized variable */
   private void SquareOut(out int x)
   {
      x = 6;      // Assign a value to caller's variable
      x = x * x;
   }// end method SquareOut

   /* Parameter x receives a copy of the value passed as argument, but does not modify caller's variable */
   private void SquareInt(int x)
   {
      x = x * x;
   }// end method SquareInt

}// end class RefAndOutParam
