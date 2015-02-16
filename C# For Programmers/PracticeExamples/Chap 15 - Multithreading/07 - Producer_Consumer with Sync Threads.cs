/* This program shows multiple threads modifying a shared object (reading or writing) WITH synchronization.
 * The threads are a Producer (write to a buffer) and a Consumer (read from a buffer)
 * 
 * An object "SynchronizedBuffer" manages the access to the "buffer" (instance variable of type int).
 * It makes sure that the buffer is in a proper state for the current thread to perform its action (produce = write (set), consume = read (get)).
 * The variable condition "occupiedBufferCount" is used to know if there is a new value in the buffer to be read from the Consumer (1) 
 * or the buffer is empty (0) and ready to receive a new value (from Producer).
 * A method is implemeted to display the current state of the system.
 * 
 * Monitor.Enter(this) is used to prevent any other threads than the current one to access the object (this = buffer).
 * Monitor.Wait(this) renders the thread into a wait state until Monitor.Pulse(this) is called.
 * Monitor.Exit(this) enables the object (this = buffer) to be released for another thread to lock this object (through a Monitor.Enter(object))
 * 
 */

using System;
using System.Threading;

namespace Chap_15_Multithreading_07
{
   /*====== Test Class ======*/
   class SynchronizedBufferTest
   {
      static void Main()
      {
         // Create shared object used by threads
         SynchronizedBuffer shared = new SynchronizedBuffer();

         // Random object used by each thread
         Random random = new Random();

         // Output column heads and initial buffer state
         Console.WriteLine("{0,-35}{1,-9}{2}\n", "Operation", "Buffer", "Occupied Count");
         shared.DisplayState("Initial state");

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

   }//end class SynchronizedBufferTest

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

   /*====== Implementation of a Synchronized shared buffer ======*/
   public class SynchronizedBuffer : Buffer
   {
      /* Instance variable */
      private int buffer = -1;               // Buffer shared by producer and consumer threads
      private int occupiedBufferCount = 0;   // Maintains count of occupied buffers

      /* Property */
      public int Buffer
      {
         get
         {
            // Obtain lock on this object
            Monitor.Enter(this);

            // If there is no data to read, placeinvoking thread in WaitSleepJoin state
            if (occupiedBufferCount == 0)
            {
               Console.WriteLine("{0} tries to read.", Thread.CurrentThread.Name);
               DisplayState("Buffer empty. " + Thread.CurrentThread.Name + " waits.");
               Monitor.Wait(this);     // enter WaitSleepJoin state. Lock is also released
            }//end if

            // indicate that producer can store another value because consumer is about to retrieve a buffer value
            --occupiedBufferCount;
            DisplayState(Thread.CurrentThread.Name + " reads " + buffer);

            // Tell waiting thread (if there is one) to become ready to execute (Running state)
            Monitor.Pulse(this);

            // Get a copy of buffer befor releasing lock.
            // It is possible that the producer could be assigned the processor immediately after the monitor is released
            // and before the return statement executes. In this case, the producer would assign a new value to buffer before
            // the return statement returns the value to the consumer. Thus, the consumer would receivethe new value.
            // Making a copy of buffer and returning the copy ensures that the consumer receives the proper value.
            int bufferCopy = buffer;

            // Release the lock on this object
            Monitor.Exit(this);

            return bufferCopy;

         }//end get

         set
         {
            // Acquire lock for this object
            Monitor.Enter(this);

            // If there are no empty locations, place invoking thread in WaitSleepJoin state
            if (occupiedBufferCount == 1)
            {
               Console.WriteLine("{0} tries to write.", Thread.CurrentThread.Name);
               DisplayState("Buffer full. " + Thread.CurrentThread.Name + " waits.");
               Monitor.Wait(this);     // enter WaitSleepJoin state. Lock is also released
            }//end if

            // Set new buffer value
            buffer = value;

            // Indicate consumer can retrieve another value
            // because producer has just stored a buffer value
            ++occupiedBufferCount;
            DisplayState(Thread.CurrentThread.Name + " writes " + buffer);

            // Tell waiting thread (if there is one) to become ready to execute (Running state)
            Monitor.Pulse(this);

            // Release lock on this object
            Monitor.Exit(this);

         }//end set

      }//end property Buffer

      /* Method */
      // Display current operation and buffer state
      public void DisplayState(string operation)
      {
         Console.WriteLine("{0,-35}{1,-9}{2}\n", operation, buffer, occupiedBufferCount);
      }//end method DisplayState

   }//end class SynchronizedBuffer

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
