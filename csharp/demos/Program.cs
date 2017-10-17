using System;

namespace demos
{
    class Program
    {
        public static void ExplicitCasting()
        {   
            // Working example
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;
            // Non-working example
            // object ActuallyInt = 256;
            // int ExplicitInt = ActuallyInt as int;
        }
        public static void Boxing()
        {
            // Checking data types for use with boxing
            object BoxedData = "This is clearly a string";
            if (BoxedData is int) {
                System.Console.WriteLine("We have an integer?");
            }
            else if (BoxedData is string) {
                System.Console.WriteLine("It is totally a string!");
            }
        }
        static void Main(string[] args)
        {
            Boxing();
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
