/* Using overloaded constructors enable us to accept non-optimal object initialization (not all parameters are passed).
 * Specifically, we can refer to the optimal constructor by passing known parameters and then give a default value to 
 * missing ones (here, 0), using ": this(...)". The body of the constructor, {} , remains empty as 
 * the optimal constructor is in charge of initializing the object properly.
 * This method enables code reuse, but mostly easier maintenance as only the optimal constructor needs to be changed
 * for the effect to be autmatically repercuted to the other constructors.

 * "private set" is used to prevent other classes to set the property, only members of the class are allowed to.
 * Here, we are forcing the use of the method SetTime to modify the value of the instance variables. 
 * A normal set cannot be performed by another class.

 * Properties are now used in all methods instead of the instance variables, 
 * and value compliance is now performed at the property level, not in SetTime anymore (compared to Test1) 
 * 
 * NOTE: If any overloaded constructor is defined, a parameterless constructor is NOT created by default by .NET.
 * Therefore, a parameterless constructor has to be defined to instantiate object with such constructor. 
 * Otherwise, a compilation error will occur.
 
 */

using System;

public class Time2Test
{
   public static void Main()
   {
      Time2 t1 = new Time2();             // 00:00:00
      Time2 t2 = new Time2(2);            // 02:00:00
      Time2 t3 = new Time2(21, 34);       // 21:34:00
      Time2 t4 = new Time2(12, 25, 42);   // 12:25:42
      Time2 t5 = new Time2(27, 74, 99);   // 00:00:00
      Time2 t6 = new Time2(t4);           // 12:25:42

      Console.WriteLine("Constructed with :\n");

      Console.WriteLine("t1: all arguments defaulted");
      Console.WriteLine("    {0}", t1.ToUniversalString());
      Console.WriteLine("    {0}\n", t1.ToString());

      Console.WriteLine("t2: hour specified");
      Console.WriteLine("    {0}", t2.ToUniversalString());
      Console.WriteLine("    {0}\n", t2.ToString());

      Console.WriteLine("t3: hour & minute specified");
      Console.WriteLine("    {0}", t3.ToUniversalString());
      Console.WriteLine("    {0}\n", t3.ToString());

      Console.WriteLine("t4: hour & minute & seconde specified");
      Console.WriteLine("    {0}", t4.ToUniversalString());
      Console.WriteLine("    {0}\n", t4.ToString());

      Console.WriteLine("t5: all invalid arguments");
      Console.WriteLine("    {0}", t5.ToUniversalString());
      Console.WriteLine("    {0}\n", t5.ToString());

      Console.WriteLine("t6: Time2 object t4 specified");
      Console.WriteLine("    {0}", t6.ToUniversalString());
      Console.WriteLine("    {0}\n", t6.ToString());

      Console.ReadLine();

   }// end Main

}// end class Time2Test

public class Time2
{
   /* Declaration of Instance Variables */
   private int hour;
   private int minute;
   private int second;

   /* Dependent Constructors that invoke the optimal one. They are called CONSTRUCTOR INITIALIZER */
   public Time2()             : this(0, 0, 0) { }     // Parameterless 
   public Time2(int h)        : this(h, 0, 0) { }     // Only hour supplied
   public Time2(int h, int m) : this(h, m, 0) { }     // Only hour and minute supplied
   public Time2(Time2 time)   : this(time.Hour, time.Minute, time.Second) { } // Another Time2 object supplied

   /* Note: This last constructor initializer can directly access the private members of object "time"
    * because it is of the same class that the calling class. But it is good programming practice to still use
    * the properties rather than the private instance variables.
    */

   /* Optimal Constructor */
   public Time2(int h, int m, int s)
   {  SetTime(h,m,s); }

   /* Properties */
   public int Hour
   {
      get { return hour; }
      private set { hour = ( ( (value >= 0) && (value < 24) ) ? value : 0 ) ;}
   }

   public int Minute
   {
      get { return minute; }
      private set { minute = (((value >= 0) && (value < 60)) ? value : 0); }
   }

   public int Second
   {
      get { return second; }
      private set { second = (((value >= 0) && (value < 60)) ? value : 0); }
   }

   /* Set time by ensuring validity of input parameters */
   public void SetTime(int h, int m, int s)
   {
      Hour = h;
      Minute = m;
      Second = s;
   }// end method SetTime

   /* Convert to string in universal-time format HH:MM:SS */
   public string ToUniversalString()
   {
      return String.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
   }// end method ToUniversalString

   /* Convert to string in a standard format H:MM:SS AM or PM */
   public override string ToString()
   {

      return String.Format("{0}:{1:D2}:{2:D2} {3}",
         (Hour == 0 || Hour == 12) ? 12 : (Hour % 12), 
         Minute, Second,
         (Hour < 12) ? "AM" : "PM" );
   }// end method ToString

}// end class Time2

