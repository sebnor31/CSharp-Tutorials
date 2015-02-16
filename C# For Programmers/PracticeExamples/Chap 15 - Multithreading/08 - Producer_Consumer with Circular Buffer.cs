/* This program shows
 * 
 * a Lock block is used to show a more succinct way to lock and release an object.
 * Therefore, Monitor.Enter() and Monitor.Exit() are implicitly called.
 */

using System;
using System.Threading;

namespace Chap_15_Multithreading_08
{
   /*====== Test Class ======*/
   class CircularBufferTest
   {
      static void Main()
      {
         // Create shared object used by threads
         CircularBuffer shared = new CircularBuffer();

         // Random object used by each thread
         Random random = new Random();

         // Display shared state before producer and consumer threads begin execution
         Console.Write(shared.CreateStateOutput());

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

         Console.ReadLine();

      }//end Main

   }//end class CircularBufferTest

   /*====== Shared Buffer ======*/
   public interface Buffer
   {
      /* Property */
      int Buffer
      {
         get;
         set;
      }//end property Buffer

   }//end interface Buffer

   /*====== Implementation of a Circular buffer (Array) ======*/
   public class CircularBuffer : Buffer
   {
      /* Instance variable */
      private int[] buffers = {-1, -1, -1};  // each array element is a buffer
      private int occupiedBufferCount = 0;   // maintains count of occupied buffers
      private int readLocation = 0;          // location of the next read
      private int writeLocation = 0;          // location of the next write

      /* Property */
      public int Buffer
      {
         get
         {
            // Lock this object while getting value from buffers array
            lock (this)
            {
               // If there is no data to read, place invoking thread in WaitSleepJoin state
               if (occupiedBufferCount == 0)
               {
                  Console.WriteLine("\nAll buffers empty. {0} waits.", Thread.CurrentThread.Name);
                  Monitor.Wait(this);     // enter WaitSleepJoin state. Lock is also released
               }//end if

               // Obtain value at current readLocation
               int readValue = buffers[readLocation];
               Console.WriteLine("{0} reads {1}", Thread.CurrentThread.Name, buffers[readLocation]);

               // Just consumed a value, so decrement number of occupied buffers
               --occupiedBufferCount;

               // Update readLocation for future read operations, then add current state to output
               readLocation = (readLocation + 1) % buffers.Length;
               Console.WriteLine(CreateStateOutput());

               // Return waiting thread (if there is one) to Running state
               Monitor.Pulse(this);

               return readValue;

            }//end lock

         }//end get

         set
         {
            // Lock this object while setting value in buffers array
            lock (this)
            {
               // If there are no empty locations, place invoking thread in WaitSleepJoin state
               if (occupiedBufferCount == buffers.Length)
               {
                  Console.WriteLine("All buffers full. {0} waits.", Thread.CurrentThread.Name);
                  Monitor.Wait(this);     // enter WaitSleepJoin state. Lock is also released
               }//end if

               // Place value in writeLocation of buffers
               buffers[writeLocation] = value;
               Console.WriteLine("{0} writes {1} ", Thread.CurrentThread.Name, buffers[writeLocation]);

               // Just produces a value, so increment number of occupied buffers
               ++occupiedBufferCount;

               // Update writeLocation for future write operations, then add current state to output
               writeLocation = (writeLocation + 1) % buffers.Length;
               Console.WriteLine(CreateStateOutput());

               // Return waiting thread (if there is one) to Running state
               Monitor.Pulse(this);
            
            }//end lock

         }//end set

      }//end property Buffer

      /* Method */
      // Create state output
      public string CreateStateOutput()
      {
         // Disply first line of state information
         string output = "(buffers occupied: " + occupiedBufferCount + ")\nbuffers: ";

         for (int i = 0; i < buffers.Length; i++)
            output += " " + string.Format("{0,2}", buffers[i]) + " ";

         output += "\n";

         // Display second line of state info
         output += "         ";

         for (int i = 0; i < buffers.Length; i++)
            output += "---";
         
         output += "\n";

         // Display third line of state info
         output += "         ";

         //Display readLocation (R) or writeLocation (W) indicators below appropriate buffer locations
         for (int i = 0; i < buffers.Length; i++)
         {
            if (i == writeLocation && writeLocation == readLocation)
               output += " WR  ";
            else if (i == writeLocation)
               output += " W   ";
            else if (i == readLocation)
               output += "  R  ";
            else
               output += "     ";
         }//end for

         output += "\n";

         return output;

      }//end method CreateStateOutput

   }//end class CircularBuffer

   /*====== Producer ======*/
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

   /*====== Consumer ======*/
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
