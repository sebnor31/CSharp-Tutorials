using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declare an Array */
            int[] myArray = new int[3];
            int[] myArray2 = new int[] {4,5,6,10};
            string[] myStringArray = new string[] {"Nordine", "Sarah" , "Sam"};

            /* Assign a value */
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            
            /* For each item Iteration */
            foreach (string name in myStringArray)
            {
                Console.Write(name);
            }
            Console.ReadLine();
           
            /* Character Manipulation */
            string saying = "The world is yours if you truly work hard " + 
                "but also care about what you do.";

            char[] charSaying = saying.ToCharArray();
            Array.Reverse(charSaying);

            foreach (char letter in charSaying)
            {
                Console.Write(letter);
            }
            Console.ReadLine();
        }
    }
}
