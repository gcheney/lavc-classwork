using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingCollections
{
    class Cow : Animal  //inherits from Animal
    {
        public Cow(string newName) : base(newName) //calls 'super' constructor and passes name value
        {
        }
        public void Milk()
        {
            Console.WriteLine("{0} has been milked.", name);
        }
    }
}
