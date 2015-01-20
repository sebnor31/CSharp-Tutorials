using System;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a grade");
            string userValue = Console.ReadLine();

            switch(userValue.ToUpper())
            {
                case "A":
                    Console.WriteLine("That is a 100");
                    break;

                case "B":
                    Console.WriteLine("That is a 90");
                    break;

                default:
                    Console.WriteLine("Not a correct grade");
                    break;
            }
            Console.ReadLine();

        }
    }
}
