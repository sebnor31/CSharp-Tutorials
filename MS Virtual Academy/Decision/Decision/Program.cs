using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaration */
            string myString = "";
            int a = 0, b = 1, c = 2 ;


            /* If Statement */
            if (a == b)
            {
                // Code here
                Console.WriteLine(myString);
            }
            else if (a == c)
            {
                // Another Code here
            }
            else
            {
                // Default Code here
                myString = Console.ReadLine();
            }


            /* For Statement */
            for (int i = 0; i < 10; i++)
            {
                // Code Here
                a = b + c;

                // Break tag
                break;
            }

        }
    }
}
