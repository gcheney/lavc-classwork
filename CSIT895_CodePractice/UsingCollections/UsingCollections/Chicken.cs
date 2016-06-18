using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollections
{
    class Chicken : Animal
    {
        public Chicken(string newName) : base(newName)
        {
        }

        public void LayEggs()
        {
            Console.WriteLine("{0} has laid an egg.", name);
        }
    }
}
