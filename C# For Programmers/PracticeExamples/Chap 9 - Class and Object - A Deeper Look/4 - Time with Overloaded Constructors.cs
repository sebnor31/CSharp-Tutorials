/* Using overloaded constructors enable us to accept non-optimal object initialization (not all parameters are passed).
 * Specifically, we can refer to the optimal constructor by passing known parameters and then give a default value to 
 * missing ones (here, 0), using ": this(...)". The body of the constructor, {} , remains empty as 
 * the optimal constructor is in charge of initializing the object properly.
 * This method enables code reuse, but mostly easier maintenance as only the optimal constructor needs to be changed
 * for the effect to be autmatically repercuted to the other constructors. */

/* "private set" is used to prevent other classes to set the property, only members of the class are allowed to.
 * Here, we are forcing the use of the method SetTime to modify the value of the instance variables. 
 * A normal set cannot be performed by another class. */

/* Properties are now used in all methods instead of the instance variables, 
 * and value compliance is now performed at the property level, not in SetTime anymore (compared to Test1) */

using System;

public class Time2Test
{
   public static void Main()
   {
     
        
      Console.ReadLine();

   }// end Main

}// end class Time2Test

public class Time2
{
   /* Declaration of Instance Variables */
   private int hour;
   private int minute;
   private int second;

   /* Dependent Constructors that invoke the optimal one */
   public Time2()             : this(0, 0, 0) { }     // Parameterless 
   public Time2(int h)        : this(h, 0, 0) { }     // Only hour supplied
   public Time2(int h, int m) : this(h, m, 0) { }     // Only hour and minute supplied
   public Time2(Time2 time)   : this(time.Hour, time.Minute, time.Second) { } // Another Time2 object supplied
   
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

