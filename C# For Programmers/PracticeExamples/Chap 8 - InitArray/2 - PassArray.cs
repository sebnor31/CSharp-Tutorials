/* Passing an array to a method is implicity done by reference, 
 * meaning the elements of the original array are modified.
 * However, passing an element of an array is done by value par default,
 * meaning no modification is performed on the method caller's original element.
 * A 'ref' accessor needs to be explicitly used to force element passed by reference.  
 */

using System;

class PassArray
{
   public static void Main()
   {
      int[] myArray = {1,2,3,4};

      /* Print original array */
      Console.Write("Original array: ");
      foreach(int elt in myArray)
         Console.Write("{0}\t", elt);

      /* Invoke ModifyArray and print modified array, no 'ref' explicitly used */
      ModifyArray(myArray);

      Console.Write("\nModified array: ");
      foreach (int elt in myArray)
         Console.Write("{0}\t", elt);

      /* Invoke modify element method, no ref used*/
      ModifyElt(myArray[1]);
      Console.WriteLine("Value of actual element: " + myArray[1]);

      Console.ReadLine();


   }// end Main

   public static void ModifyArray(int[] array)
   {
      for ( int i = 0; i < array.Length; i++ )
         array[i] *= 2;
   }// end method ModifyArray

   public static void ModifyElt(int elt)
   {
      elt *= 2;
      Console.WriteLine("\nValue of modified element: " + elt);
   }// end method ModifyElt

}// end class PassArray

