using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceLibrary
{
    internal class Bird : Animal
    {
        private double wingspan;

        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }


        public new void Speak()
        {
            Console.WriteLine("Chirp");
        }
    }
}
