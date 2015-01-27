/* Exceptions are handled through a "try" statement composed of a "try" block, followed by "catch" blocks and at the end a "finally" block.
 * 
 * The "try" block will execute sequentially until an exception is thrown (e.g., from a method). 
 * Execution then stops and control goes to following block (catch or finally).
 * 
 * The "catch" block is responsible to handle the exception. It can have no parameters (catch all) or at most 1 parameter (Exception type or its derived classes).
 * According to the type of exception, the first matching "catch" block is executed and the exception does not hold true anymore.
 * 
 * 
 * The "finally" block is always executed, no matter if an exception occurs or is handled.
 * This is the right location to execute any resource releasing tasks.
 */ 

using System;

namespace Chap_12_Exceptions
{
   public class UsingExceptions
   {
      static void Main()
      {
         /* Case 1: No exceptions occur in a called method */
         Console.WriteLine("Calling DoesNotThrowException");
         DoesNotThrowException();

         /* Case 2: Exception occurs and is caught in called method */
         Console.WriteLine("\nCalling ThrowExceptionWithCatch");
         ThrowExceptionWithCatch();

         /* Case 3: Exception occurs but is not caught in called method because there is no catch block */
         Console.WriteLine("\nCalling ThrowExceptionWithoutCatch");

         // call ThrowExceptionWithoutCatch
         try
         {
            ThrowExceptionWithoutCatch();
         }//end try
         catch
         {
            Console.WriteLine("Caught exception from " + "ThrowExceptionWithoutCatch in Main");
         }//end catch

         /* Case 4: Exception occurs and is caught in called method, then rethrown to caller */
         Console.WriteLine("\nCalling ThrowExceptionCatchRethrown");

         // call ThrowExceptionCatchRethrown
         try
         {
            ThrowExceptionCatchRethrown();
         }//end try
         catch
         {
            Console.WriteLine("Caught exception from " + "ThrowExceptionCatchRethrown in Main");
         }//end catch

         Console.ReadLine();
      }//end method Main


      /*** Methods ***/
      private static void DoesNotThrowException()
      {
         try
         {
            Console.WriteLine("In DoesNotThrowException");
         }//end try
         catch
         {
            Console.WriteLine("This catch never executes");
         }//end catch
         finally
         {
            Console.WriteLine("Finally executed in DoesNotThrowException");
         }//end finally

         Console.WriteLine("End of DoesNotThrowException");

      }//end method DoesNotThrowException

      private static void ThrowExceptionWithCatch()
      {
         try
         {
            Console.WriteLine("In ThrowExceptionWithCatch");
            throw new Exception("Exception in ThrowExceptionWithCatch");
         }//end try
         catch(Exception exceptionParameter)
         {
            Console.WriteLine("Message: " + exceptionParameter.Message);
         }//end catch
         finally
         {
            Console.WriteLine("finally executed in ThrowExceptionWithCatch");
         }//end finally

         Console.WriteLine("End of ThrowExceptionWithCatch");

      }//end method ThrowExceptionWithCatch

      private static void ThrowExceptionWithoutCatch()
      {
         try
         {
            Console.WriteLine("In ThrowExceptionWithoutCatch");
            throw new Exception("Exception in ThrowExceptionWithoutCatch");
         }//end try
         finally
         {
            Console.WriteLine("finally executed in ThrowExceptionWithoutCatch");
         }//end finally
         
         //Unreachable Code; logic error
         Console.WriteLine("End of ThrowExceptionWithoutCatch");

      }//end method ThrowExceptionWithoutCatch

      private static void ThrowExceptionCatchRethrown()
      {
         try
         {
            Console.WriteLine("In ThrowExceptionCatchRethrown");
            throw new Exception("Exception in ThrowExceptionCatchRethrown");
         }//end try
         catch (Exception exceptionParameter)
         {
            Console.WriteLine("Message: " + exceptionParameter.Message);
            throw;      // rethrow  exception for further processing

            // Unreachable code; logic error

         }//end catch
         finally
         {
            Console.WriteLine("finally executed in ThrowExceptionCatchRethrown");
         }//end finally

         Console.WriteLine("End of ThrowExceptionCatchRethrown");

      }//end method ThrowExceptionCatchRethrown


   }//end class UsingExceptions

}//end namespace Chap_12_Exceptions
