using System;
using System.Collections.Generic;
using System.Linq;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1. Print 1-255
            // print1to255();

            // // 2. Print odd numbers 1-255
            // printOdds1to255();

            // // 3. Print sum from 0-255
            // printSum1to255();

            // // 4. Iterating through an array
            // int[] numbers = {1, 3, 5, 7, 9, 13};
            // iterateThroughArray(numbers);

            // // 5. Find max of an array
            // int[] arr = {1, 3, 5, 7, -9, -13};
            // findMax(arr);

            // // 6. Get Average
            // int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // findAvg(arr);

            // // 7. Array with odd numbers 
            // oddNumsArray();

            // // 8. Greater than Y
            // int[] example = {1, 3, 5, 7};
            // int y = 3;
            // greaterThanY(example, y);

            // // 9. Square the Values
            // int[] squareArray = {1, 5, 10, -2};
            // squareArrValues(squareArray);

            // // 10. Eliminate negative numbers
            // int[] negArray = {1, 5, 10, -2};
            // elimNegNumbers(negArray);

            // // 11. Min, Max, and Average
            // int[] x = {1, 5, 10, -2};
            // minMaxAvg(x);

            // // 12. Shifting values in an array
            // int[] x = {1, 5, 10, 7, -2};
            // shiftVals(x);

            // 13. Number to string
            int[] x = {-1, -3, 2};
            numToString(x);
        }

        static void print1to255()
        {
            int x = 0;
            while(x < 256)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        static void printOdds1to255()
        {
            int j = 1;
            while(j < 256)
            {
                Console.WriteLine(j);
                j += 2;
            }  
        }

        static void printSum1to255()
        {
            int n = 0;
            int sum = 0;
            while(n < 256)
            {
                Console.WriteLine("New number: {0} Sum: {1}", n, sum);
                n++;
                sum += n;
            }
        }

        static void iterateThroughArray(int[] calledarray)
        {
            foreach (int i in calledarray)
            {
                Console.WriteLine("{0} ", i);
            }
        }

        static void findMax(int[] calledarray)
        {
            Console.WriteLine(calledarray.Max());
        }

        static void findAvg(int[] calledarray)
        {
            int count = 0;
            int sum = 0;
            int avg = 0;
            foreach (int i in calledarray)
            {
                count += 1;
                sum += i;
            }
            avg = sum/count;
            Console.WriteLine(avg);
        }

        static void oddNumsArray()
        {
            int m = 1;
            int count = 0;
            int arrLength = (256/2);
            int[] oddsArr = new int[arrLength];

            while(m < 256)
            {
                oddsArr[count] = m;
                count ++;
                m += 2;
                // System.Console.WriteLine("Count: {0} and m: {1}", count, m);
            }
            Array.ForEach(oddsArr, x => Console.WriteLine(x));
        }

        static void greaterThanY(int[] givenArray, int y)
        {
            int count = 0;
            foreach (int z in givenArray)
            {
                if (z > y)
                {
                    count += 1;
                }
            }
            System.Console.WriteLine(count);
        }

        static void squareArrValues(int[] any)
        {
            int count = 0;
            foreach (int n in any)
            {
                any[count] = n*n;
                count ++;
            }
            Array.ForEach(any, x => Console.WriteLine(x));
        }

        static void elimNegNumbers(int[] any)
        {
            int count = 0;
            foreach (int i in any)
            {
                if (any[count] < 0)
                {
                    any[count] = 0;
                }
                count++;
            }
            Array.ForEach(any, x => Console.WriteLine(x));
        }

        static void minMaxAvg(int[] x)
        {
            double max = x.Max();
            double min = x.Min();
            double avg = x.Average();
            System.Console.WriteLine("Max: {0}, Min: {1}, Avg: {2}", max, min, avg);
        }

        static void shiftVals(int[] x)
        {
            int count = 0;
            while (count < x.Length)
            {
                if (count == x.Length - 1)
                {
                    x[count] = 0;
                }
                else
                {
                x[count] = x[count + 1];
                }
                count++;
            }
            Array.ForEach(x, y => Console.WriteLine(y));
        }

        static void numToString(int[] x)
        {
            int count = 0;
            string[] xStrings = new string[x.Length];
            foreach (int i in x)
            {
                if (x[count] < 0)
                {
                    xStrings[count] = "Dojo";
                }
                else
                {
                    xStrings[count] = x[count].ToString();
                }
                count++;
            }
            Array.ForEach(xStrings, y => Console.WriteLine(y));
        }
    }
}
