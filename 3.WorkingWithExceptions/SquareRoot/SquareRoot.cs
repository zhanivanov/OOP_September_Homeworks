using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            try
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(num));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good-bye");
            }
        }
    }
}
