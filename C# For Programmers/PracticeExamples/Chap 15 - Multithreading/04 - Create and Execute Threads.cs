using System;
using System.Threading;

namespace Chap_15_Multithreading_04
{
   class ThreadTester
   {
      static void Main()
      {
         // Create and name each Thread.
         // Use MessagePrinter's PRint method as argument to ThreadStart delegate
         MessagePrinter printer1 = new MessagePrinter();
         Thread thread1 = new Thread(new ThreadStart(printer1.Print));
         thread1.Name = "thread_1";

         MessagePrinter printer2 = new MessagePrinter();
         Thread thread2 = new Thread(new ThreadStart(printer2.Print));
         thread2.Name = "thread_2";

         MessagePrinter printer3 = new MessagePrinter();
         Thread thread3 = new Thread(new ThreadStart(printer3.Print));
         thread3.Name = "thread_3";

         Console.WriteLine("Starting threads");

         // Call each thread's Start method to place each thread in Running state
         thread1.Start();
         thread2.Start();
         thread3.Start();

         Console.WriteLine("Threads Started\n");

         Console.ReadLine();

      }//end Main

   }//end class ThreadTester

   /*** Print Message of this class used to control threads ***/
   class MessagePrinter
   {
      /* Instance variable */
      private int sleepTime;
      private static Random random = new Random();

      /* Constructor */
      public MessagePrinter()
      {
         // pick random sleep time between 0 and 5 seconds
         sleepTime = random.Next(5001);   // 5000 ms maximum
      }//end constructor

      /* Method Print controls threads that prints messages */
      public void Print()
      {
         // Obtain reference to currently executing thread
         Thread current = Thread.CurrentThread;

         // Put thread to sleep for sleepTime amount of time
         Console.WriteLine("{0} going to sleep for {1} ms", current.Name, sleepTime);
         Thread.Sleep(sleepTime);

         // Print thread name
         Console.WriteLine("{0} done sleeping", current.Name);
      }//end method Print

   }//end class MessagePrinter

}//end namespace
