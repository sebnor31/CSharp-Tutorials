/* 
 */ 

using System;

namespace Chap_12
{
   public class Properties
   {
      static void Main()
      {
         // Method1 will generate an exception of type Exception that will be caught
         try { Method1(); }

         // A FormatException is wrapped as an InnerException inside an Exception type
         catch (Exception exceptionParameter)
         {
            /* Ouptut the string representation of the Exception, then output properties InnerException, Message and StackTrace */
            Console.WriteLine("exceptionParameter.ToString: \n{0}\n", exceptionParameter.ToString());
            Console.WriteLine("exceptionParameter.Message: \n{0}\n", exceptionParameter.Message);
            Console.WriteLine("exceptionParameter.StackTrace: \n{0}\n", exceptionParameter.StackTrace);
            Console.WriteLine("exceptionParameter.InnerException: \n{0}\n", exceptionParameter.InnerException.ToString());
         }
        
         Console.ReadLine();
      }//end method Main

      private static void Method1()
      { Method2(); }

      private static void Method2()
      { Method3(); }

      private static void Method3()
      {
         // attempt to convert a string to int
         try { Convert.ToInt32("Not an Integer"); }

         catch (FormatException formatExceptionParameter)
         { 
            // Wrap FormatException in new Exception
            throw new Exception("Exception occurred in Method3", formatExceptionParameter); 
         }

      }//end method Method3

   }//end class Properties

}//end namespace Chap_12
