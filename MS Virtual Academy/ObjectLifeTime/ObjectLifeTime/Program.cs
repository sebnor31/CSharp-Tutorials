using System;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myHonda = new Car();
            Car myNissan = new Car("Nissan", "Camry", 1980, "Blue");

            Console.WriteLine("My Honda: {0} - {1} - {2} - {3}",
                myHonda.Make, myHonda.Model, myHonda.Year, myHonda.Color);

            Console.WriteLine("My Nissan: {0} - {1} - {2} - {3}",
                myNissan.Make, myNissan.Model, myNissan.Year, myNissan.Color);

            Console.ReadLine();
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car()
        {
            this.Make = "Honda";
            this.Model = "Accord";
            this.Color = "Black";
            this.Year = 2007;
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }

    }
}
