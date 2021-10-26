using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 53;
            while (number < 96)
            {
                if (number % 7 == 0)
                    Console.WriteLine(number);

                number++;
            }


        }
    }
}
