using System;

namespace _2iCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MULTIPLE OF 7 UP UNTIL 100");
            //MULTIPLES OF 7 UP TO 100
            int seven_times_table = 1;
            while (seven_times_table <= 100)
            {
                if (seven_times_table % 7 == 0)
                    Console.WriteLine(seven_times_table);

                seven_times_table++;
            }
            Console.WriteLine("MULTIPLE OF 8 UP UNTIL 200");
            //MULTIPLES OF 8 UP TO 200
            int eight_times_table = 1;
            while (eight_times_table <= 200)
            {
                if (eight_times_table % 8 == 0)
                    Console.WriteLine(eight_times_table);

                eight_times_table++;
            }
            Console.WriteLine("MULTIPLE OF 9 UP UNTIL 300");
            //MULTIPLES OF 9 UP TO 300
            int nine_times_table = 1;
            while (nine_times_table <= 300)
            {
                if (nine_times_table % 9 == 0)
                    Console.WriteLine(nine_times_table);

                nine_times_table++;
            }

        }
    }
}
