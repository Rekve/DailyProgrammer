using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Easy
{

    public class CalculatingTheStandardDeviation
    {
        /// <summary>
        /// http://www.reddit.com/r/dailyprogrammer/comments/35l5eo/20150511_challenge_214_easy_calculating_the/
        /// </summary>

        public static void CakculateStandardDeviation()
        {
            int[] TestNumbers1 = { 5, 6, 11, 13, 19, 20, 25, 26, 28, 37 };
            int[] TestNumbers2 = { 37, 81, 86, 91, 97, 108, 109, 112, 112, 114, 115, 117, 121, 123, 141 };

            Console.WriteLine(StandardDevation(TestNumbers1));
            Console.WriteLine(StandardDevation(TestNumbers2));
        }

        private static double StandardDevation(int[] numbers)
        {
            int size = numbers.Length;
            double mean = numbers.Sum() / size;
            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += Math.Pow((numbers[i] - mean), 2);
            }

            return Math.Sqrt(sum / size);
        }
    }
}
