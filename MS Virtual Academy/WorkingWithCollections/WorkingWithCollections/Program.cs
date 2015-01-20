using System;
using System.Collections.Generic;


namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Author = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            /* Creation of a Loosely Typed Dictionary (Special Type of Collections) */
            System.Collections.Specialized.ListDictionary myDict = new System.Collections.Specialized.ListDictionary();

            /* Adding Elements to the dictionary */
            myDict.Add(car1.Make, car1);
            myDict.Add(car2.Make, car2);
            myDict.Add(b1.Author, b1);

            /* Read from the dictionary. 
                 - myDict[key] returns the value associated to the key inside []  
                 - (Car) casting is needed to enable accessing the propriety Model from a Car class
            */
            Console.WriteLine(((Car)myDict["Oldsmobile"]).Model);
            Console.WriteLine(((Car)myDict[car2.Make]).Model);


            /* Now, Creation of a STRONGLY typed List */
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            
            foreach(Car car in myList)
            {
                Console.WriteLine("Make is {0} and Model is {1}", car.Make, car.Model);
            }

            /* Now, Creation of a STRONGLY typed Dictionary */
            Dictionary<string, Car> myCarDict = new Dictionary<string, Car>();
            myCarDict.Add(car1.Make, car1);
            myCarDict.Add(car2.Make, car2);

            Console.WriteLine("The model is: {0}", myCarDict["Oldsmobile"].Model);

            /* Creating and Initializing a class more compactly */
            Car nordineTuture = new Car() { Make = "Honda" , Model = "Accord"};

            /* Creating and Initilaiazing a List more compactly */
            List<Car> nordineCarList = new List<Car>() {
                new Car {Make = "Renault" , Model = "R5"},
                new Car {Make = "Ferrari" , Model = "Monti"}
            };

            Console.WriteLine("My new car will be a {0} {1}", nordineCarList[1].Make, nordineCarList[1].Model);

            /* Press q to quit */
            Console.Write("-- Press 'q' to exit -- ");
            string userVal = Console.ReadLine();
            while (userVal.ToUpper() != "Q")
            {
                userVal = Console.ReadLine();
            }
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
