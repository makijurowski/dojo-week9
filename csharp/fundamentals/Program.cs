using System;

namespace fundamentals
{
    class Program
    {
        public static void loopVals()
        {
            for (int x = 1; x < 256; x++)
            {
                System.Console.WriteLine(x);
            }
        }

        public static void divisibleBy3or5()
        {
            for (int x = 1; x < 101; x++)
            {
                if (divisibleBy3(x) && divisibleBy5(x)) {}
                else if (divisibleBy3(x))
                {
                    System.Console.WriteLine("{0} divisible by 3", x);
                }
                else if (divisibleBy5(x))
                {
                    System.Console.WriteLine("{0} divisible by 5", x);
                }
                else {}
            }
        }

        public static void divisibleBy3or5Words()
        {
            for (int x = 1; x < 101; x++)
            {
                if (divisibleBy3(x) && divisibleBy5(x)) 
                {
                    System.Console.WriteLine("{0} = FizzBuzz", x);
                }
                else if (divisibleBy3(x))
                {
                    System.Console.WriteLine("{0} = Fizz", x);
                }
                else if (divisibleBy5(x))
                {
                    System.Console.WriteLine("{0} = Buzz", x);
                }
                else {}
            }  
        }

        static bool divisibleBy3(int x)
        {
            int remainder = x % 3;
            if (remainder == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool divisibleBy5(int x)
        {
            int remainder = x % 5;
            if (remainder == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // loopVals();
            // divisibleBy3or5();
            // divisibleBy3or5Words();
        }
    }
}
