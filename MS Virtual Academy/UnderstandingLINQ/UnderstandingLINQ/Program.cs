using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make = "BMW", Model= "550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009},
                new Car() { Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010},
                new Car() { Make="BMW", Model = "745li", Color=CarColor.Black, StickerPrice=75000, Year=2008},
                new Car() {Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=25000, Year=2008},
                new Car() {Make="BMW", Model="55i", Color=CarColor.Black, StickerPrice=57000, Year=2010}
            };

            /* Use LINQ (Language Integrated Query) to select a subset of myCars list */
            var bmws = from bmwCar in myCars
                       where bmwCar.Make == "BMW"
                       && bmwCar.Year < 2010
                       select bmwCar;

            /* Use LINQ to order data */
            var orderedCars = from car in myCars
                              orderby car.Year descending     // Descending is used to reverse order (remove it for normal order)
                              select car;

            /* Method filtering method, alternative to LINQ */
            var _bmws2010 = myCars.Where(p => p.Make == "BMW").Where(p => p.Year == 2010);
            var _orderedCars = myCars.OrderByDescending(p => p.Year);
            var sum = myCars.Sum(p => p.StickerPrice);

            /* Use a foreach to display the matching cars to the user */
            foreach (var selectedCar in _orderedCars)
                Console.WriteLine("{0} - {1} - {2}", selectedCar.Make, selectedCar.Model, selectedCar.Year);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}
