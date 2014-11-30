using System;

public class GradeBook
{
   /* Instance variable of the course name for this GradeBook */
   private string courseName;    // Name of course this gradebook represents
   private int[,] grades;         // 2-D rectangular array of student grades (row: student , col: class)

   /* Property to get and set the course name */
   public string CourseName
   {
      get { return courseName; }
      set { courseName = value; }
   }// end property CourseName

   /* Constructor */
   public GradeBook(string name, int[,] gradesArray)
   {
      CourseName = name;
      grades = gradesArray;

   } // end Constructor 

   /* Display a welcome message to the Gradebook user */
   public void DisplayMessage()
   {
      Console.WriteLine("Welcome to the Grade Book for {0}!\n", CourseName);
   } // end method DisplayMessage

   /* Perform various operations on the data */
   public void ProcessGrades()
   {
      // Output grades array
      OutputGrades();

      // Get Max and Min grades
      Console.WriteLine("\nLowest grade is {0}\nHighest grade is {1}\n", GetMinimum(), GetMaximum());

      // Print grade distribution chart
      OutputBarChart();

   }// end method ProcessGrades

   /* Find minimum grade */
   private int GetMinimum()
   {
      int lowGrade = grades[0,0];  // Assume lowest grade is first elt in table

      foreach (int grade in grades)
      {
         if (grade < lowGrade)
            lowGrade = grade;
      }// end foreach

      return lowGrade;

   }// end method GetMinimum

   /* Find maximum grade */
   private int GetMaximum()
   {
      int maxGrade = grades[0,0];  // Assume highest grade is first elt in table

      foreach (int grade in grades)
      {
         if (grade > maxGrade)
            maxGrade = grade;
      }// end foreach

      return maxGrade;

   }// end method GetMaximum

   /* Find average grade */
   private double GetAverage(int student)
   {
      int amount = grades.GetLength(1);   // Get the number of grades for a student
      int total = 0;

      for(int exam = 0 ; exam < amount ; exam++ )
         total += grades[student,exam];

      return ( (double) total / amount );
   }// end method GetAverage

   /* Output bar chart displaying grade distribution */
   private void OutputBarChart()
   {
      Console.WriteLine("Overall Grade Distribution:");

      // Store frequency of grades in each range of 10 grades
      int[] frequency = new int[11];

      // Increment appropriate frequency based on grades
      foreach (int grade in grades)
         ++frequency[grade/10];

      // Print bar chart for each grade frequency
      for (int count = 0; count < frequency.Length; count++)
      {
         // output bar label
         if (count == 10)
            Console.Write("  100: ");
         else
            Console.Write("{0:D2}-{1:D2}: ", count * 10, count * 10 + 9);

         // print bar of asterisks
         for (int stars = 0; stars < frequency[count]; stars++)
            Console.Write("*");

         Console.WriteLine();
         
      }// end for

   }// end method OutputBarChart

   /* Output the contents of the grades array */
   private void OutputGrades()
   {
      Console.WriteLine("The grades are:\n");
      Console.Write("{0,12}", "");     // Align column headers
      
      // Print column header
      for (int test = 0; test < grades.GetLength(1); test++)
         Console.Write("Test {0}  ", test + 1);

      Console.WriteLine("Average"); 

      // Print students grades and average
      for (int student = 0; student < grades.GetLength(0); student++)
      {
         Console.Write("Student {0,2}" , student+1);

         for (int studGrade = 0; studGrade < grades.GetLength(1); studGrade++)
            Console.Write("{0,8}" , grades[student, studGrade]);

         Console.WriteLine("{0,9:F2}", GetAverage(student));
      }// end For
   
   }// end method OutputGrades

} // end class GradeBook
