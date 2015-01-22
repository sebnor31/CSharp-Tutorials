/* An indexer is a propety-like member to get/set class members value.
 * It enables non-integer indexing (e.g., string) to access a desired element of a data list (e.g., array). 
 * Indexers are always public due to its property-like nature (syntax error o.w.).
 */
using System;

public class BoxTest
{
   public static void Main()
   {
      /* Create a box */
      Box box = new Box(30,30,30);

      /* Show dimensions with the numeric indexer */
      Console.WriteLine("Created a box with the dimensions:");
      Console.WriteLine("box[ 0 ] = {0}", box[0]);
      Console.WriteLine("box[ 1 ] = {0}", box[1]);
      Console.WriteLine("box[ 2 ] = {0}", box[2]);

      /* Set a dimension with the numeric indexer */
      box[0] = 10;

      /* Set a dimension with the string indexer */
      box["width"] = 20;

      /* Show dimensions with the string indexer */
      Console.WriteLine("New box with the dimensions:");
      Console.WriteLine("box[ \"length\" ] = {0}", box["length"]);
      Console.WriteLine("box[ \"width\" ] = {0}", box["width"]);
      Console.WriteLine("box[ \"height\" ] = {0}", box["height"]);


      Console.ReadLine();
   }// end Main

}// end class BoxTest

public class Box
{
   /* Declaration of Instance Variables */
   private string[] names = { "length", "width", "height" };
   private double[] dimensions = new double[3];

   /* Constructor */
   public Box(double length, double width, double height)
   {
      dimensions[0] = length;
      dimensions[1] = width;
      dimensions[2] = height;

   }// end constructor Box()

   /* Indexer to access dimensions by integer index number */
   public double this[int index]
   {
      get
      {
         // Validate index to get
         if (index < 0 || index >= dimensions.Length)
            return -1;
         else
            return dimensions[index];
      }// end get

      set
      {
         // Validate index to set
         if (index >= 0 && index < dimensions.Length)
            dimensions[index] = value;
      }// end set

   }// end Indexer[int]

   /* Indexer to access dimensions by integer index number */
   public double this[string name]
   {
      get
      {
         // Locate element to get
         int i = 0;
         while ( ( names[i] != name.ToLower() ) && ( i < names.Length ) )
            i++;

         return (i != names.Length) ? dimensions[i] : -1;
      }// end get

      set
      {
         // Locate element to set
         int i = 0;
         while ((names[i] != name.ToLower()) && (i < names.Length))
            i++;

         if (i != names.Length)
            dimensions[i] = value;
      }// end set

   }// end Indexer[string]

}// end class Box

