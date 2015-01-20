using System;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "i700";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F50";
            myTruck.Color = "Green";
            myTruck.Year = 2000;
            myTruck.TowinCapacity = 120;

            printVehicleDetails(myTruck);
            
            Console.ReadLine();

        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's details: {0}",
                vehicle.FormatMe());
        }
    }


    /* Abstract means that this class cannot be instanciated, it is merely a template that other classes can derive from */
    abstract class Vehicle 
    {
        /* Proprietes */
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public abstract string FormatMe();  
        // abstract methods means an overriden method has to be created for each derived class,
        // but no definition is provided in the abstract class as it has to be overriden


    }


    /* Car is a child/sub/derived class of parent/super class Vehicule */
    class Car : Vehicle     
    {
        /* Constructor */
        public Car()
        {
            this.Make = "Toyota";
            this.Model = "Camry";
            this.Year = 1900;
            this.Color = "White";
        }

        /* Overriden Method as imposed by abstract definition on parent class */ 
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }

    }


    /* Truck is derived from Vehicule. Sealed means no child can be created from this class */
    sealed class Truck : Vehicle   
    {
        /* Added Proprietes to Vehicule class */
        public int TowinCapacity { get; set; }

        /* Constructor */
        public Truck()
        {
            this.Make = "Ram";
            this.Model = "Glory";
            this.Year = 1900;
            this.Color = "Black";
            this.TowinCapacity = 1000;
        }

        /* Overriden Method as imposed by abstract definition on parent class */ 
        public override string FormatMe()   // Override needed to signal a will to override the parent's method
        {
            return String.Format("{0} - {1} - {2} Towing Units",
                this.Make,
                this.Model,
                this.TowinCapacity);
        }

    }

}
