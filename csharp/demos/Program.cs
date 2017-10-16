using System;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int start = 0;
            int end = 5;
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = start; i < end; i ++)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while (j < 6)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
        }
    }
}
