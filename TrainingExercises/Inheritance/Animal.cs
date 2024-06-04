using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal : LivingThing
    {

        public string name;
        public string favToy;
        public int age;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getFavToy()
        {
            return favToy;
        }
        public void setFavToy(string favToy)
        {
            this.favToy = favToy;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }


        public AnimalType Type { get; set; }
        public string Breed { get; set; } = DateTime.Now.ToString();

        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }

        
    }
}
