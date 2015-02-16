/* This program shows multiple threads modifying a shared object (reading or writing) without synchronization */

using System;
using System.Threading;

namespace Chap_15_Multithreading_06
{
   class UnsynchronizedBufferTest
   {
      static void Main()
      {
         // Create shared object used by threads
         UnsynchronizedBuffer shared = new UnsynchronizedBuffer();

         // Random object used by each thread
         Random random = new Random();

         // Create Producer and Consumer objects
         Producer producer = new Producer(shared, random);
         Consumer consumer = new Consumer(shared, random);  

         // Create threads for producer and consumer and set delegates for each thread
         Thread producerThread = new Thread( new ThreadStart(producer.Produce) );
         producerThread.Name = "Producer";

         Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
         consumerThread.Name = "Consumer";

         // Start each thread
         producerThread.Start();
         consumerThread.Start();

         Console.WriteLine("\n====== End of Main ========");
         Console.ReadLine();

      }//end Main

   }//end class UnsynchronizedBufferTest

   /* Shared Buffer */
   public interface Buffer
   {
      /* Property */
      int Buffer
      {
         get;
         set;
      }//end property Buffer

   }//end interface Buffer

   /* Implementation of an Unsynchronized shared buffer */
   public class UnsynchronizedBuffer : Buffer
   {
      private int buffer = -1;

      public int Buffer
      {
         get
         {
            Console.WriteLine("{0} reads {1}", Thread.CurrentThread.Name, buffer);
            return buffer;
         }
         set
         {
            Console.WriteLine("{0} writes {1}", Thread.CurrentThread.Name, value);
            buffer = value;
         }

      }//end property Buffer

   }//end class UnsynchronizedBuffer

   /* Producer */
   // Controls a thread that stores value from 1 to 10 in sharedLocation
   public class Producer
   {
      private Buffer sharedLocation;
      private Random randomSleepTime;

      /* Constructor */
      public Producer(Buffer shared, Random random)
      {
         sharedLocation = shared;
         randomSleepTime = random;
      }//end constructor

      /* Store values 1-10 in object sharedLocation */
      public void Produce()
      {
         // Sleep for random interval up to 3000 ms then set sharedLcoation's buffer property
         for (int count = 1; count <= 10; count++)
         {
            Thread.Sleep(randomSleepTime.Next(1, 3001));
            sharedLocation.Buffer = count;
         }//end for

         Console.WriteLine("{0} done producing.\nTerminating {0}", Thread.CurrentThread.Name);

      }//end method Produce

   }//end class Producer

   // Controls a thread that loops 10 times and reads a value from sharedLocation
   public class Consumer
   {
      private Buffer sharedLocation;
      private Random randomSleepTime;
      
      /* Constructor */
      public Consumer(Buffer shared, Random random)
      {
         sharedLocation = shared;
         randomSleepTime = random;
      }//end constructor

      /* Read sharedLocation's value ten times */
      public void Consume()
      {
         int sum = 0;

         // Sleep for random interval up to 3000 ms then add sharedLocation's buffer property value to sum 
         for (int count = 1; count <= 10; count++)
         {
            Thread.Sleep(randomSleepTime.Next(1, 3001));
            sum += sharedLocation.Buffer;
         }//end for

         Console.WriteLine("{0} read values totaling: {1}.\nTerminating {0}.", Thread.CurrentThread.Name, sum);

      }//end method Consume
      

      


   }//end class Consumer


}//end namespace
