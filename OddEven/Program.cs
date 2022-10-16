using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Even Program");

            Console.Write("Enter a interger Number : ");

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"You Enter {num} is Even Nuber ");
            }
            else
            {
                Console.WriteLine($"You Enter {num} is Odd Number ");
            }


            Console.ReadKey();
          


        }
    }
}
