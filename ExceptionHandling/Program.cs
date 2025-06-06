using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Nunber");
            int b =int .Parse(Console.ReadLine());

            try {

                int result = a / b;
                Console.Write("The result is: " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divde by zero");
            }

            Console.WriteLine();


            Console.WriteLine("Line 1");
            Console.WriteLine("Line 2");
            Console.WriteLine("Line 3");
        }
    }
}
