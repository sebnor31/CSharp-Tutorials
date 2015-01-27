/* "using" statement can be used in another context than referencing namespaces for convenience.
 * It can be used to better manage resources by simplifying the code.
 * It implicitly implements a try/finally statement and calls IDispose.Dispose() to perform releasing tasks.
 * Therefore, the object type has be derived from IDispose (interface).
 */ 

// Classic "using" in terms of namespace references
using System;

public class UsingForResource
{
   static void Main()
   {
      /***********************************************************/
      /** This "using" relates to resource management **/
      using (ExampleObject exampleObject = new ExampleObject())
      {
         exampleObject.SomeMethod();
      }
      /***********************************************************/


      /***********************************************************/
      /** The previous using statement is similar than following try statement **/
      ExampleObject exampleObjectCopy = new ExampleObject();

      try
      { exampleObjectCopy.SomeMethod(); }
      finally
      {
         if (exampleObjectCopy != null)
            ((IDisposable)exampleObjectCopy).Dispose();
      }
      /***********************************************************/


   }//end method Main

}//end class UsingForResource


/* The class has to have an IDisposable interface for "using" to work */
public class ExampleObject : IDisposable
{
   public void SomeMethod()
   { /* Method body */ }

   public void Dispose()
   {/* Method body */ }

}//end class ExampleObject





