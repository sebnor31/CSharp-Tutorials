using System;

namespace UnderstandingScope
{
    class Program
    {
        
        /* Declare higher scope variable available for all methods of Program Class */
        private static string k = "";
        private static Car myCar = new Car();

        static void Main(string[] args)
        { 
            for (int i = 0; i < 10; i++)
            {
                k = i.ToString();
            }

            Console.WriteLine("k: " + k);           
            helperMethod();
            myCar.PublicMethodCar();

            Console.ReadLine();
        }

        static void helperMethod()
        {
            // k is still accessible in this method, even if changed in main
            Console.WriteLine("Helper k: " + k);
        }
    }

    class Car
    {
        // NAMING CONVENTION: Public method starts with a Capital letter
        public void PublicMethodCar()
        {
            Console.WriteLine("Public Car Method");
            Console.ReadLine();
        }

        // NAMING CONVENTION: Private methods uses camel case
        private void privateMethodCar()
        {
        }
    }
}
