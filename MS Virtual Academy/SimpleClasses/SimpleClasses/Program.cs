using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Renault";
            myNewCar.Model = "Spider";
            myNewCar.Year = 1991;
            myNewCar.Color = "Green";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make, 
                myNewCar.Model,
                myNewCar.Year);

            Console.WriteLine("Market Value is: {0:C}", 
                myNewCar.DetermineMarketValue());
            Console.ReadLine();
        }


    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }

    }


}
