using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumbers
{
    static void Main(string[] args)
    {
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            ReadNumber(start, end);
            if (i+1 < 2)
            {
                Console.WriteLine("You entered {0} number", i + 1);
            }
            else
            {
                Console.WriteLine("You entered {0} numbers", i + 1);
            }
        }
    }

    private static void ReadNumber(int start, int end)
    {
        int num = 0;
            try
            {
                Console.WriteLine("Enter a number between {0} and {1}: ", start, end);
                num = int.Parse(Console.ReadLine());
                if (num <= start || num >= end)
                {
                    Console.WriteLine("Invalid input! Your number must be between {0} and {1}!", start, end);
                    ReadNumber(start, end);
                }
                else
                {
                    Console.WriteLine("You entered a valid number! --> '{0}'", num);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
                ReadNumber(start, end);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number! The number is too big to fit in int32!");
                ReadNumber(start, end);
            }
        }
}