using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Standard Array
            Console.WriteLine("Create an Array type collection of Animal "
                             + "objects and use it:");

            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Deidre");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Ken");

            foreach (Animal myAnimal in animalArray)
            {
                Console.WriteLine("New {0} object added to Array collection, " +
                                 "Name = {1}", myAnimal.ToString(), myAnimal.Name);
            }

            Console.WriteLine("Array Collection contains {0} objects.", animalArray.Length);
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEggs();
            Console.WriteLine();

            //Arraylist type and usage
            Console.WriteLine("Create an ArrayList type collection of Animal "
                             + "objects and use it:");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Hayley");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Roy"));

            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("New {0} object added to ArrayList collection, " +
                                 "Name = {1}", myAnimal.ToString(), myAnimal.Name);
            }

            Console.WriteLine("ArrayList contains {0} objects.", animalArrayList.Count);
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArray[1]).LayEggs();
            Console.WriteLine();

            Console.WriteLine("Additional manipulations of an ArrayList: ");
            animalArrayList.RemoveAt(0);
            //animalArrayList.Remove(myCow2); - same function as above
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEggs();
            Console.WriteLine("The animal called {0} is at index {1}.", 
                             myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Janice";
            Console.WriteLine("The animal is now called {0}.", ((Animal)animalArrayList[1]).Name);

            Console.ReadKey();
        }
    }
}
