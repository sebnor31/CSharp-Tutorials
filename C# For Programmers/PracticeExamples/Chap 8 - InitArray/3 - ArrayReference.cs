/* Array objects are passed to methob by reference. But the array reference is passed by value.
 * The array reference can also be passed by reference, allowing the variable to point to another array object,
 * using 'ref' as a variable accessor in the parameter/argument decalaration.
 */

using System;

class ArrayReference
{
   public static void Main()
   {
      // Create and initialize firstArray
      int[] firstArray = { 1, 2, 3 };
      // Copy the reference in variable firstArray
      int[] firstArrayCopy = firstArray;

      Console.WriteLine("Test passing firstArray reference by value");
      Console.Write("\nContents of firstArray before calling FirstDouble:\n\t");

      // Print content of firstArray
      foreach (int elt in firstArray)
         Console.Write(elt + "\t");

      /* Pass variable firstArray by value to FirstDouble.
       * Variable reference is passed by value, but elements are accessed by reference */
      FirstDouble(firstArray);

      // Print new content of firstArray
      Console.Write("\nContents of firstArray after calling FirstDouble:\n\t");

      foreach (int elt in firstArray)
         Console.Write(elt + "\t");

      // Test whether reference was changed by FirstDouble
      if (firstArray == firstArrayCopy)
         Console.WriteLine("\nThe references refer to the same array");
      else
         Console.WriteLine("\n\nThe references refer to different arrays");

      /* ************************************************************** */
      /* Create and initialize second array */
      int[] secondArray = { 1, 2, 3 };
      int[] secondArrayCopy = secondArray;

      Console.WriteLine("\nTest passing secondArray reference by reference");
      Console.Write("\nContents of secondArray before calling SecondDouble:\n\t");

      // Print content of secondArray
      foreach (int elt in secondArray)
         Console.Write(elt + "\t");

      /* Pass variable secondArray by reference to SecondDouble.
       * Variable reference is passed by reference */
      SecondDouble(ref secondArray);

      // Print new content of secondArray
      Console.Write("\nContents of secondArray after calling SecondDouble:\n\t");

      foreach (int elt in secondArray)
         Console.Write(elt + "\t");

      // Test whether reference was changed by SecondDouble
      if (secondArray == secondArrayCopy)
         Console.WriteLine("\nThe references refer to the same array");
      else
         Console.WriteLine("\n\nThe references refer to different arrays");


      Console.ReadLine();

   }// end Main

   public static void FirstDouble(int[] array)
   {
      /* Multiply each array elt by 2 */
      for (int i = 0; i < array.Length; i++)
         array[i] *= 2;

      /* Attempt to modify array reference to a new array object */
      array = new int[] { 11, 12, 13 };

   }// end method FirstDouble

   public static void SecondDouble(ref int[] array)
   {
      /* Multiply each array elt by 2 */
      for (int i = 0; i < array.Length; i++)
         array[i] *= 2;

      /* Attempt to modify array reference to a new array object */
      array = new int[] { 11, 12, 13 };

   }// end method SecondDouble

}// end class ArrayReference

