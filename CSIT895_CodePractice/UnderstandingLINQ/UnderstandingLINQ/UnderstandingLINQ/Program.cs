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
                new Car() {Make = "BMW", Model="z23", Mileage = 500, Color=CarColor.Black},
                new Car() {Make = "ford", Model="focus", Mileage = 20, Color=CarColor.White},
                new Car() {Make = "BMW", Model="xxx", Mileage = 600, Color=CarColor.Red},
            };

            //Select All from List
            var allCars = from car in myCars
                          select car;

            //LINQ statements - like SQL
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Mileage > 500
                       select car;

            //Select a row - returns anonymous type
            var newCars = from car in myCars
                          where car.Mileage < 500
                          select new { car.Make, car.Model, car.Mileage };

            //Ordered queries - auto sorts in ascending order
            var orderedCars = from car in myCars
                              orderby car.Mileage descending
                              select car;

            //Method-based syntax
            var _bmws = myCars.Where(car => car.Mileage > 500).Where(car => car.Make == "BMW");

            //Order method-based syntax
            var _orderedCars = myCars.OrderByDescending(car => car.Mileage);

            //foreach loop with LINQ statement 
            foreach (var car in _orderedCars)
            {
                Console.WriteLine("Make: {0}  Model: {1} - {2} miles", car.Make, car.Model, car.Mileage);
            }

            var sum = myCars.Sum(car => car.Mileage);
            Console.WriteLine("Total Milage is: " + sum);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue
    }
}
