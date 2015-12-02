using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path to file
            var text = System.IO.File.ReadAllText(@"input.txt");
            //Splits the array on newlines
            var array = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            //Gets the sum
            var totalSum = array.Sum(s => GetSum(s));

            Console.WriteLine(totalSum);
        }

        private static int GetSum(string line)
        {
            var split = line.Split('x');
            //Converts all the sides to int, instead of string
            int l = Convert.ToInt32(split[0]);
            int w = Convert.ToInt32(split[1]);
            int h = Convert.ToInt32(split[2]);

            //Part 1
            int[] areas = new int[3];
            areas[0] = l * w;
            areas[1] = w * h;
            areas[2] = h * l;

            int sideA = 2 * areas[0] + 2 * areas[1] + 2 * areas[2] + areas.Min();

            //Part 2
            int[] perims = new int[3];
            perims[0] = l * 2 + w * 2;
            perims[1] = w * 2 + h * 2;
            perims[2] = h * 2 + l * 2;
            int sideB = l * w * h + perims.Min();

            //Return sideA for answer to question one
            //Return sideB for answer to question two
            return sideA;
        }
    }
}
