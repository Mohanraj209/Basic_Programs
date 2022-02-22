using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    public class Basic_pgms
    {

        static Random random = new Random();

        public static void Coin_Toss()
        {
            int count = 0;
            int headCount = 0;
            int tailCount = 0;
            float headPercent = 0;
            float tailPercent = 0;
            double toss = 0;

            do
            {
                Console.Write("\n Enter a positive integer: ");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count < 0);
            for (int i = 0; i < count; i++)
            {
                toss = random.NextDouble();
                if (toss < 0.5)
                    headCount++;
                else
                    tailCount++;
            }
            headPercent = (float)headCount / (float)(headCount + tailCount);
            tailPercent = (float)tailCount / (float)(tailCount + headCount);
            Console.WriteLine("Head count: " + headCount + " Head Percent: " + headPercent);
            Console.WriteLine("Tail count: " + tailCount + " Tail Percent: " + tailPercent);
        }

        /// <summary>
        /// Code for Leap Year.. 
        /// </summary>
        public static void Leap_Year()
        {
            int year;
            Console.Write("\n Enter the Year :");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("{0} is Leap Year", year);
            else
                Console.WriteLine("{0} is not a Leap Year", year);
        }

        /// <summary>
        /// Code for Power of 2..
        /// </summary>
        public static void Power_Two()
        {
            int num;
            Console.WriteLine("\n Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Power of 2: ");
            for (int i = 0; i <= num; i++)
            {
                int result = ((int)Math.Pow(2, i));

                if (result <= 0 || result < 31)
                {

                    Console.WriteLine("Result is: " + result);
                }
                else
                {
                    Console.WriteLine("Value overflows int value, try again!");
                }
            }
        }

        /// <summary>
        /// Code for Harmonic series..
        /// </summary>
        public static void Harmonic_num()
        {
            // TODO Auto-generated method stub

            double sum = 0, n, i;
            Console.WriteLine("\n Please Enter the value of n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                sum = sum + (1 / i);
                if (i == 1)
                   Console.WriteLine("1/ " + i);

                else if (i == n)
                    Console.WriteLine("1/ " + i);

                else
                    Console.WriteLine("1/ " + i);
            }
            Console.WriteLine("The Sum of the Series : " + sum);
        }


        public static void Factors()
        {

           Console.WriteLine("\n Enter a number :");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if (num > 2)
            {
                Console.WriteLine(num);
            }
        }
    }

}