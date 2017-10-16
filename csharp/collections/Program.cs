using System;

namespace collections
{
    class Program
    {
        public static void BasicArrays()
        {
            int[] zeroToNine = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] alternate = {true, false, true, false, true, false, true, false, true, false};
            Array.ForEach(zeroToNine, x => Console.WriteLine(x));
            Array.ForEach(names, x => Console.WriteLine(x));
            Array.ForEach(alternate, x => Console.WriteLine(x));
        }

        public static void MultiplicationTable()
        {
            int[] oneToTen = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] newRow = new int[10];

            for (int i = 0; i < 10; i++)
            {
                newRow[i] = i + 1;
            }
            
            // foreach (int n in newRow)
            // {
            //     System.Console.WriteLine(n);
            // }

            int cols = 10;
            int rows = 10;
            int count = 1;
            int[,] multTable = new int[rows, cols];

            for (int n = 0; n < rows; n++)
            {
                System.Console.WriteLine(count);
                for (int m = 0; m < cols; m++)
                {
                    multTable[n, m] = count + (m + 1);
                    System.Console.WriteLine(multTable[n, m]);
                }
                count++;
            }

        }

        static void Main(string[] args)
        {
            // BasicArrays();
            MultiplicationTable();
        }
    }
}
