using System;

namespace UnderstandingEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declaration of an enum variable */
            SuperHero mySuperHero;

            /* Read from user */
            Console.WriteLine("Type in the name of a superhero:");
            string userValue = Console.ReadLine();
            
            /* Check if user input is matching a value from enum SuperHero */
            if (Enum.TryParse<SuperHero>(userValue, true, out mySuperHero))
	        {
                // Use snippet "switch" -> double tab -> replace default variable by enum var -> double enter
                switch (mySuperHero)
                {
                    case SuperHero.Batman:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Good Bat man");
                        break;
                    case SuperHero.Superman:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Good Super man");
                        break;
                    case SuperHero.GreenLantern:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Good Green Lantern");
                        break;
                    default:
                        break;
                }
	        }
            else
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a superhero");
            }
            
            Console.ReadLine();
        }
    }

    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
