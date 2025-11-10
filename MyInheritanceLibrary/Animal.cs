using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceLibrary
{
    public class Animal
    {
        private string name;
        private int age;
        private int numberOfLegs;


        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        { 
            get { return age; } 
            set { age = value; } 
        }

        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }


        //methods
        public void Speak()
        {
            Console.WriteLine("Hello");
        }
    }
}
