/* "Internal" is an access specifier (such as Public) that only enables objects on the same assembly to access it.
 * When the assembly is compiled in a library, the outside caller cannot access the internal elements.
 * 
 * In our exple, another assembly cannot have access to class InternalData as a non-specified class defaults to internal access-specifier 
 */ 

using System;

public class InternalAccessTest
{
   public static void Main()
   {
      InternalData internalData = new InternalData();

      Console.WriteLine("After instantiation:\n{0}", internalData);

      internalData.number = 77;
      internalData.message = "Good bye";

      Console.WriteLine("After changes:\n{0}", internalData);

      Console.ReadLine();

   }//end method MAin

}// end InternalAccessTest


class InternalData
{
   /* Internal access instance variables */
   internal int number;
   internal string message;

   /* Constructor */
   public InternalData()
   {
      number = 0;
      message = "Hello";
   }// end constructor InternalData

   /* Method to return string representation of the object */
   public override string ToString()
   {
      return string.Format("Number: {0}; Message: {1}", number, message);
   }// end method ToString

}// end class InternalData

