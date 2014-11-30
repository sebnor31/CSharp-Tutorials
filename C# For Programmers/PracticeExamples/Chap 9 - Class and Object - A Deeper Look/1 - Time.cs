using System;

public class Time1Test
{
   public static void Main()
   {
      /* new Time1 creates an instance (or object) of the class Time1
       * sunset is declared as a Time1 type, enabling it to accept a reference to a Time1 object */
      Time1 sunset = new Time1();

      /* Print initial values of the Time1 attributes */
      Console.WriteLine("The initial universal time is: {0}",  sunset.ToUniversalString()  );
      Console.WriteLine("The initial standard time is: {0}",   sunset.ToString()           );
      Console.WriteLine("\n***************************************\n");

      /* Change time and output updated time */
      sunset.SetTime(13, 27, 6);
      Console.WriteLine("Updated universal time is: {0}", sunset.ToUniversalString());
      Console.WriteLine("Updated standard time is: {0}", sunset.ToString());
      Console.WriteLine("\n***************************************\n");

      /* Set time with invalid values */
      sunset.SetTime(99, 99, 99);
      Console.WriteLine("Invalid universal time is: {0}", sunset.ToUniversalString());
      Console.WriteLine("Invalid standard time is: {0}", sunset.ToString());
      Console.WriteLine("\n***************************************\n");
           

      Console.ReadLine();

   }// end Main

}// end class Time1Test

public class Time1
{
   /* Declaration of Instance Variables */
   private int hour;
   private int minute;
   private int second;

   /* Set time by ensuring validity of input parameters */
   public void SetTime(int h, int m, int s)
   {
      hour = ( ( (h >= 0) && (h < 24) ) ? h : 0 );
      minute = ( ( (m >= 0) && (m < 60) ) ? m : 0 );
      second = ( ( (s >= 0) && (s < 60) ) ? s : 0 );

   }// end method SetTime

   /* Convert to string in universal-time format HH:MM:SS */
   public string ToUniversalString()
   {
      return String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
   }// end method ToUniversalString

   /* Convert to string in a standard format H:MM:SS AM or PM */
   public override string ToString()
   {

      return String.Format("{0}:{1:D2}:{2:D2} {3}", 
         (hour == 0 || hour == 12) ? 12 : (hour % 12) , 
         minute, second,
         (hour < 12) ? "AM" : "PM" );
   }// end method ToString

}// end class Time1

