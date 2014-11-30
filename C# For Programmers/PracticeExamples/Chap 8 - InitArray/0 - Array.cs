using System;

public class Array
{
   public static void Main()
   {
      StudentPoll();
      Console.ReadLine();
   }// end Main
   
   public static void InitArray()
   {
      /* Declare Array without list initializer */
      int[] array1;            // declare array named array
      array1 = new int[10];    // Create the space for array and initialize to default zeros

      /* Declare Array with list initializer */
      int[] array2 = { 2, 4, 6, 8, 10 };  // No need to use a new int[...] as compiler creates it for us

      /* Declare Array with constant */
      const int ARRAY_LENGTH = 10;       // By convention, use capital letters for constants
      int[] array3 = new int[ARRAY_LENGTH];


      // Header
      Console.WriteLine("{0}{1,8}", "Index", "Value");

      for ( int i = 0 ; i < array2.Length ; i++ )
      {
         Console.WriteLine("{0,5}{1,8}", i, array2[i]);
      }

      Console.ReadLine();

   }// end method InitArray

   public static void RollDie()
   {
      Random randomNum = new Random();
      
      int[] frequency = new int[7];

      for (int roll = 1; roll <= 6000; roll++)
      {
         ++frequency[randomNum.Next(1, 7)];
      }

      Console.WriteLine("{0,4}{1,10}", "Face", "Frequency");

      for (int face = 1; face < frequency.Length; face++)
      {
         Console.WriteLine("{0,4}{1,10}", face, frequency[face]);
      }

   }// end method RollDie

   public static void StudentPoll()
   {
      int[] responses = { 1, 5, 6, 4, 8, 5, 9, 7, 8, 10 };
      int[] frequency = new int[11];

      foreach(int elt in responses)
      {
         ++frequency[elt];
      }

      Console.WriteLine("Rating Frequency");

      for (int i = 1; i < frequency.Length; i++)
      {
         Console.WriteLine("{0,6} {1,9}", i, frequency[i]);
      }
   }// end method StudentPoll

}// end class Array
