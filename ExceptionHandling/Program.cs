using System;
using System.Collections.Concurrent;
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
            //Console.WriteLine("Enter the first Number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Nunber");
            //int b =int .Parse(Console.ReadLine());

            //try {

            //    int result = a / b;
            //    Console.Write("The result is: " + result);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divde by zero");
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine();

            int act_balance = 5000;
            int with_balance = 6000;


            try
            {
                if (act_balance < with_balance)
                {
                    throw new Exception("Insufficient balance");
                }
                else
                {

                    Console.WriteLine(act_balance - with_balance);
                }
            }
            catch (Exception e) {

                Console.WriteLine(e.Message);
            }

            



            

        }
    }
}
