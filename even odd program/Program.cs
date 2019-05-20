using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_program
{
    class Program
    {
        //This program will find the number is even or add
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number = ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("Number is even number");
            }
            else
            {
                Console.WriteLine("Number is odd number");
            }
        }
    }
}
