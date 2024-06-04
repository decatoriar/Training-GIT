using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmallestValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let the user to input 10 integers and display the smallest value. And handle input errors.

            int[] myNumber = new int[10];

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {
                myNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("The smaller value is: " + myNumber.Min());


            Console.ReadLine();
        }

    }
}
