using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceLibrary
{
    internal class Dog : Animal
    {
        public new void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
