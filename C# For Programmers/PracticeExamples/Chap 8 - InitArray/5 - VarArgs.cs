/* A variable-length argument list, which has an arbitrary number of arguments, 
 * can be passed to a method using the keyword 'params'.
 * A 1-D array needs to be used in conjection with params .
 * Varargs (other name for var-length args list) can only be used at the end of the arg list.
 */

using System;

class VarArgs
{
   public static void Main()
   {
      double d1 = 10.0;
      double d2 = 20.0;
      double d3 = 30.0;
      double d4 = 40.0;

      Console.WriteLine("Average of d1 and d2 is {0:F1}" , Average(d1, d2) );
      Console.WriteLine("Average of d1, d2 and d3 is {0:F1}", Average(d1, d2, d3));
      Console.WriteLine("Average of d1, d2, d3 and d4 is {0:F1}", Average(d1, d2, d3, d4));

      Console.ReadLine();

   }// end Main

   private static double Average(params double[] numbers)
   {
      double total = 0.0;
      
      foreach(double number in numbers)
         total += number;

      return total / numbers.Length;
   }

}// end class VarArgs

