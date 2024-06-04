using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Dog : Animal
    {
        public Dog(string name, string favToy, int age) {
            setName(name);
            setFavToy(favToy);
            setAge(age);
        }

        //my 3 methods
        public void eat() {
            Console.WriteLine("\t" + getName() + " is eating.\n");
        }
        public void watch()
        {
            Console.WriteLine("\t" + getName() + " is watching.\n");
        }
        public void bath()
        {
            Console.WriteLine("\t" + getName() + " is taking a bath.\n");
        }


        // override methods from Animal class
        public override void MakeNoise()
        {
            Console.WriteLine("\tWoof! Woof! Woof!\n");
        }
        public override void Sleep()
        {
            Console.WriteLine("\t" + getName() + " is now sleeping\n");
        }

        public override void Grow()
        {
            
        }
    }
}
