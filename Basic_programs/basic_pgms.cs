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
                Console.ReadLine();
        }
    }

}