using System;

public class MultiDimensionArray
{
   public static void Main()
   {
      // Create a rectangular array (same number of columns for each row)
      int[,] rectangular = { {1, 2, 3} , {4, 5, 6} };    // 2x3 array 

      // Create a jagged array (# columns can be different)
      int[][] jagged = {  new int[] {1,2},
                          new int[] {3}, 
                          new int[] {4, 5, 6}
                       };

      OutputArray(rectangular);
      Console.WriteLine("*******************************");
      OutputArray(jagged);

      Console.ReadLine();

   }// end Main

   /* Print rows and columns of a rectangular array */
   private static void OutputArray( int[,] array)
   {
      Console.WriteLine("Values in the rectangular array by row are: ");

      for (int row = 0; row < array.GetLength(0); row++ )
      {
         for (int column = 0; column < array.GetLength(1); column++)
            Console.Write("{0}  ", array[row, column]);

         Console.WriteLine();
      }// end for

   }// end method OutputArray


   /* Print rows and columns of a jagged array */
   private static void OutputArray(int[][] array)
   {
      Console.WriteLine("Values in the jagged array by row are: ");

      for (int row = 0; row < array.Length; row++)
      {
         for (int column = 0; column < array[row].Length; column++)
            Console.Write("{0}  ", array[row][column]);

         Console.WriteLine();
      }// end for

   }// end method OutputArray

}// end class MultiDimensionArray
