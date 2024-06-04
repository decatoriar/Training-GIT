using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This application will create a <name of specific animal> object.\n");

                //TODO: Create an instance of the derived animal class.

                

                //TODO: Assign value to all of the object properties.

                string name, favToy;
                int age, choseAnimal;


                Console.WriteLine("Pick one:\n");

                Console.WriteLine("[1] Dog");
                Console.WriteLine("[2] Cat");
                choseAnimal = Convert.ToInt32(Console.ReadLine());

                if (choseAnimal == 1)
                {
                    Console.Write("Enter dog's name:");
                    name = Console.ReadLine();

                    Console.Write("Enter dog's favorite toy:");
                    favToy = Console.ReadLine();

                    Console.Write("Enter dog's age:");
                    age = Convert.ToInt32(Console.ReadLine());

                    Dog myDog = new Dog(name, favToy, age);

                    //TODO: Add codes that display value of the object properties.

                    Console.WriteLine("\nYour dog's information:\n");
                    Console.WriteLine("Dog's name: " + myDog.getName());
                    Console.WriteLine("Dog's age: " + myDog.getAge());
                    Console.WriteLine("Dog's favorite toy: " + myDog.getFavToy());

                    //TODO: Add codes that invokes all of the object actions.

                    Console.WriteLine("Your dog's ability:\n");
                    Console.WriteLine(myDog.getName() + " can eat.");
                    myDog.eat();

                    Console.WriteLine(myDog.getName() + " can watch.");
                    myDog.watch();

                    Console.WriteLine(myDog.getName() + " can take a bath.");
                    myDog.bath();

                    Console.WriteLine("Your dog can also:\n");
                    Console.WriteLine(myDog.getName() + " can make a noise.");
                    myDog.MakeNoise();

                    Console.WriteLine(myDog.getName() + " can sleep.");
                    myDog.Sleep();
                }
                else if (choseAnimal == 2)
                {
                    Console.Write("Enter cat's name:");
                    name = Console.ReadLine();

                    Console.Write("Enter cat's favorite toy:");
                    favToy = Console.ReadLine();

                    Console.Write("Enter cat's age:");
                    age = Convert.ToInt32(Console.ReadLine());

                    Cat myDog = new Cat(name, favToy, age);

                    //TODO: Add codes that display value of the object properties.

                    Console.WriteLine("\nYour cat's information:\n");
                    Console.WriteLine("cat's name: " + myDog.getName());
                    Console.WriteLine("cat's age: " + myDog.getAge());
                    Console.WriteLine("cat's favorite toy: " + myDog.getFavToy());

                    //TODO: Add codes that invokes all of the object actions.

                    Console.WriteLine("Your cat's ability:\n");
                    Console.WriteLine(myDog.name + " can eat.");
                    myDog.roll();

                    Console.WriteLine(myDog.getName() + " can watch.");
                    myDog.watch();

                    Console.WriteLine(myDog.getName() + " can take a bath.");
                    myDog.bath();

                    Console.WriteLine("Your dog can also:\n");
                    Console.WriteLine(myDog.getName() + " can make a noise.");
                    myDog.MakeNoise();

                    Console.WriteLine(myDog.getName() + " can sleep.");
                    myDog.Sleep();
                }

                


                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("Error. Please try again.");
                throw;
            }
        }
    }
}
