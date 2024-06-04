using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {

        static bool IsPalindrome(int number)
        {
            string
            numStr = number.ToString();
            int
            length = numStr.Length;
            for
            (
            int
            i = 0; i < length / 2; i++)
            {
                if
                (numStr[i] != numStr[length - i - 1])
                    
                    return
                    false;
            }
            return
            true;
        }
        static void Main(string[] args)
        {
            int maxPalindrome = 0;
            int num1 = 0, num2 = 0;

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    int product = i * j;
                    if (IsPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product;
                        num1 = i;
                        num2 = j;
                    }
                }
            }

            Console.WriteLine("Largest palindrome product of two 3-digit numbers:");
            Console.WriteLine($"{num1} * {num2} = {maxPalindrome}");

            Console.ReadLine();
        }
    }
}
