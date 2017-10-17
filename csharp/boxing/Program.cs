using System;
using System.Collections.Generic;
using System.Linq;

namespace boxing
{
    class Program
    {
        public static void Boxing()
        {
            int totalIntSum = 0;
            List<object> RealEmptyList = new List<object>()
            {
                7,
                28,
                -1,
                true,
                "chair"
            };
            // foreach (object item in RealEmptyList.GetType().GetProperties())
            foreach (object item in RealEmptyList)
            {
                long myLength = RealEmptyList.Count;
                if (item is int) {
                    System.Console.WriteLine(item);
                    totalIntSum += Convert.ToInt32(item);
                }
                else if (item is string) {
                    System.Console.WriteLine(item);
                }
                else if (item is bool) {
                    System.Console.WriteLine(item);
                }
                else if (item is object) {
                    System.Console.WriteLine(item);
                }
                else {
                    System.Console.WriteLine("This did not work!");
                }
            }
            System.Console.WriteLine("Total sum of all integers: {0}", totalIntSum);
        }
        static void Main(string[] args)
        {
            Boxing();
        }
    }
}
