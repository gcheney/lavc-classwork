using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";

            Car car2 = new Car();
            car2.Make = "Toyota";
            car2.Model = "Prius";

            Book book1 = new Book("Book", "Author");

            /*
            //Loosely typed - accepts all object types
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (object o in myArrayList)
            {
             * //Cast the object
                Console.WriteLine(((Car)o).Make);
            }

            Console.WriteLine(book1.getAuthor());

            ListDictionary myDictionary = new ListDictionary();

            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);

            //Use key to access in myDictionary
            Console.WriteLine(((Car)myDictionary["Ford"]).Model);

            */

            //Generic collections type
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine("Make: {0}\nModel: {1}\n", car.Make, car.Model);
                Console.WriteLine("Make: " + car.Make + "\nModel: " + car.Model + "\n");
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string,Car>();
            myDictionary.Add(car1.Make, car1);
            myDictionary.Add(car2.Make, car2);

            Console.WriteLine(myDictionary["Ford"].Model);


            //Enumeration Practice 

            Console.Write("Type in a Superhero name to see his nickname: ");
            string userValue = Console.ReadLine();

            Superhero myValue;
            if (Enum.TryParse<Superhero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    default:
                        Console.WriteLine("Does not compute");
                        break;
                }
            }
            else
            {
                Console.WriteLine("I dont knwo that name");
            }

            string[] names = { "Bob", "John", "Steve" }; //Initialize a string array

            //Object Initialization practic
            Car car3 = new Car() { Make = "Oldsmobile", Model = "Cutlas" };
            Car car4 = new Car() { Make = "Geo", Model = "Altima" };

            //Collection Initializer 
            List<Car> initList = new List<Car>(){
                new Car {Make = "Ford", Model = "Focus"},
                new Car {Make = "Kia", Model = "Korean"}
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        private string Title, Author;
        public Book(string t, string a)
        {
            Title = t;
            Author = a;
        }

        public string getTitle()
        {
            return Title;
        }

        public string getAuthor()
        {
            return Author;
        }
    }

    enum Superhero
    {
        Batman,
        Superman
    }
}
