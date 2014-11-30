using System;

class RandomInteger
{
   static void Main()
   {
      Random die = new Random();

      /* Loop 20 times */
      for (int counter = 1; counter <= 20; counter++)
      {
         Console.Write("{0} ", die.Next(1, 7));

         if ((counter % 5) == 0)
            Console.WriteLine();
      
      }// end for

      Console.ReadLine();

   }// end method Main

}// end class RandomInteger

