/* Keyword "this" is used as an explicit reference to a class's members (instance variables, methods, etc.). 
 * If a local variable is defined in a method and has the same name than a field (or instance variable) of its class,
 * the local variable is then hiding the field, and therefore used by default.
 * Using "this" enables to unhide the field and use it in the method.
 */
using System;

public class ThisTest
{
   public static void Main()
   {
      SimpleTime time = new SimpleTime(15,30,19);

      Console.WriteLine(time.BuildString());
           
      Console.ReadLine();

   }// end Main

}// end class ThisTest

public class SimpleTime
{
   /* Declaration of Instance Variables */
   private int hour;
   private int minute;
   private int second;

   /* If constructor uses parameter names identical to instance variable names
    * the "this" reference is required to distinguish between names  */
   public SimpleTime(int hour, int minute, int second)
   {
      this.hour = hour;
      this.minute = minute;
      this.second = second;

   }// end constructor SimpleTime

   /* Use explicit and implicit "this" to call ToUniversalString */
   public string BuildString()
   {
      return string.Format("{0,24}: {1}\n{2,24}: {3}",
         "this.ToUniversalString()" , this.ToUniversalString(),
         "ToUniversalString()", ToUniversalString() );

   }// end method BuildString

   /* Convert to string in universal-time format HH:MM:SS */
   public string ToUniversalString()
   {
      // "this" not required here because method doesn't have local variables with same names as instance variables
      return String.Format("{0:D2}:{1:D2}:{2:D2}", this.hour, this.minute, this.second);

   }// end method ToUniversalString

}// end class SimpleTime

