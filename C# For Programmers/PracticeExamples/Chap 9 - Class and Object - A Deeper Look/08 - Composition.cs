/* Composition is the concept of referencing objects of other classes as members.
 * This is an implementation of a code reuse.
 * Here, a Date class is created and referenced inside an Employee object
 */

using System;

public class EmployeeTest
{
   public static void Main()
   {
      Date birth = new Date(24, 7, 1949);
      Date hire = new Date(12, 3, 1988);
      Employee employee = new Employee("Bob", "Blue", birth, hire);

      Console.WriteLine(employee);
      Console.ReadLine();
   }// end Main

}// end class EmployeeTest

public class Employee
{
   /* Instance variables */
   private string firstName;
   private string lastName;
   private Date birthDate;
   private Date hireDate;

   /* Constructor */
   public Employee(string first, string last, Date dateOfBirth, Date dateOfHire)
   {
      firstName = first;
      lastName = last;
      birthDate = dateOfBirth;
      hireDate = dateOfHire;
   }// end constructor Employee

   /* Method */

   // Convert Employee to string format
   public override string ToString()
   {
      return String.Format("{0}, {1}  Hired: {2}  Birthday: {3}",
         lastName, firstName, hireDate, birthDate);   // NOTE: hireDate & birthDate implicitly call ToString()
   }// end method ToString

}// end class Employee

public class Date
{
   /* Instance variables */
   private int day;     // 1-31 based on month
   private int month;   // 1-12
   private int year;    // any year (could validate)

   /* Properties */
   public int Day
   {
      get { return day; }// end get
      private set
      {
         int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

         // Check if day in range for month
         if (value > 0 && value <= daysPerMonth[Month])
         {
            day = value;
         }// end if

         // Check for leap year
         else if( Month == 2 && value == 29 &&
            ( Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0) ) )
         {
            day = value;
         }// end else if

         // If invalid day, maintain object in consistent state by defaulting to 1
         else
         {
            Console.WriteLine("Invalid day {0} set to 1.", value);
            day = 1; 
         }// end else

      }// end set
   }// end property Day

   public int Month
   {
      get { return month; }// end get
      private set 
      {
         // Check if month value is within 1-12 
         if(value > 0 && value <= 12)
         {
            month = value;
         }// end if

         // For invalid month, maintain object in consistent state b defaulting month to 1
         else
         {
            Console.WriteLine("Invalid month {0} set to 1.");
            month = 1;
         }// end else

      }// end set
   }// end property Month

   public int Year
   {
      get { return year; }// end get
      private set
      {
         year = value;  // could validate

      }// end set
   }// end property Year

   /* Constructor */
   public Date(int theDay, int theMonth, int theYear)
   {
      Month = theMonth;
      Year = theYear;
      Day = theDay;     // NOTE: Day is set after Month and Year as it needs their values to validate its own value

      Console.WriteLine("Date object constructor for date {0}", this);  // "this" implicitly calls ToString()

   }// end constructor Date()

   /* Methods */

   // Return a string of the form month/day/year
   public override string ToString()
   {
      return String.Format("{0}/{1}/{2}", Month, Day, Year); 
   }// end method ToString

}// end class Date

