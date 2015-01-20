using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create an instance of the object DateTime and grab the current value */
            DateTime myDateTime = DateTime.Now;

            /* Display different formated string of myDateTime */D:\Programming\C#\Tutorials\DatesAndTimes\DatesAndTimes\Program.cs
            //Console.WriteLine(myDateTime.ToString());
            //Console.WriteLine(myDateTime.ToShortDateString());
            //Console.WriteLine(myDateTime.ToShortTimeString());
            //Console.WriteLine(myDateTime.ToLongDateString());
            //Console.WriteLine(myDateTime.ToLongTimeString());

            ///* Pick up only one desired value of the myDateTime */
            //Console.WriteLine(myDateTime.Day);
            //Console.WriteLine(myDateTime.Month);
            //Console.WriteLine(myDateTime.Year);

            /* Create a file name with date and time */
            int subjectNb = 12;
            string fileName = String.Format("PPG_Sub{0}_{1}_{2}_{3}_{4}_{5}_{6}", subjectNb, myDateTime.Year, myDateTime.Month, 
                myDateTime.Day, myDateTime.Hour, myDateTime.Minute, myDateTime.Second);

            Console.WriteLine(fileName);
            Console.ReadLine();
        }
    }
}
