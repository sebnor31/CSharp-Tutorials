/* "Static" can be used to make a class member shared across all instances of the class.
 * In this example, "count" is incremented at each Employee object instantiation.
 * Therefore, any Employee can now how many other employees exist.
 * 
 * Read-only members are used by only specifying a "get" access to their properties. 
 * 
 * The Garbage Collector runs at some random time to find unreferenced objects.
 * It calls the Destructor of the class to perform closing tasks.
 * The Destructor cannot be explicitly called by the developer, only by the GC. But the GC can be explicitly invoked.
 */

using System;

public class Employee2Test
{
   public static void Main()
   {
      /* Show that count is 0 before creating employees */
      Console.WriteLine("Employees before instantiation: {0}", Employee2.Count);

      /* Create 2 Employees */
      Employee2 e1 = new Employee2("Nordine", "Sebkhi");
      Employee2 e2 = new Employee2("Marwan", "Chawqi");

      /* Show count after creating employees */
      Console.WriteLine("\nEmployees after instantiation: {0}", Employee2.Count);

      /* Get names of employees */
      Console.WriteLine("\nEmployee 1: {0} {1}\nEmployee 2; {2} {3}\n", 
         e1.FirstName, e1.LastName, e2.FirstName, e2.LastName);

      /* In this exple, there is only 1 reference to each Employee2,
       * So the following statement cause the CLR to mark each Employee2 object as being eligible for destruction 
       */
      e1 = null;
      e2 = null;

      /* Garbage Collector */
      GC.Collect();                    // Force Garbage Collection to occur now
      GC.WaitForPendingFinalizers();   // Wait until destructors finish writing to the console

      /* Show employee count after destruction occurred */
      Console.WriteLine("\nEmployees after destruction: {0}", Employee2.Count);

      Console.ReadLine();

   }// end method Main

}// end Employee2Test

public class Employee2
{
   /* Instance variable */
   private string firstName;
   private string lastName;
   private static int count = 0;    // Number of objects in memory

   /* Properties */
   //The properties are made READ-ONLY by omitting the "set" specifier 
   public string FirstName
   {
      get { return firstName; }

   }// end property FirstName

   public string LastName
   {
      get { return lastName; }

   }// end property LastName

   public static int Count
   {
      get { return count; }

   }// end property Count

   /* Constructor */
   public Employee2(string first, string last)
   {
      firstName = first;
      lastName = last;
      count++;
      Console.WriteLine("Employee constructor: {0} {1}; count = {2}", FirstName, LastName, Count);
   }// end constructor Employee2

   /* Destructor */
   ~Employee2()
   {
      count--;    // decrement static count of employees
      Console.WriteLine("Employee DEstructor: {0} {1}; count = {2}", FirstName, LastName, Count);
   }// end destructor

}// end class Employee

