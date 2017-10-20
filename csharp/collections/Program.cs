using System;
using System.Collections.Generic;
using System.Linq;

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
            int cols = 10;
            int rows = 10;
            long[,] multTable = new long[rows, cols];

            for (int n = 0; n < rows; n++)
            {
                for (int m = 0; m < cols; m++)
                {
                    multTable[n, m] = (n + 1)*(m + 1);
                    if (multTable[n, m] > 9)
                    {
                        Console.Write(string.Format("{0}   ", multTable[n, m]));
                    }
                    else 
                    {
                        Console.Write(string.Format(" {0}   ", multTable[n, m]));
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public static List<string> ListOfFlavors()
        {
            List<string> iceCreamFlavors = new List<string>();
            iceCreamFlavors.Add("Vanilla");
            iceCreamFlavors.Add("Chocolate");
            iceCreamFlavors.Add("Strawberry");
            iceCreamFlavors.Add("Swirl");
            iceCreamFlavors.Add("Lemon");
            System.Console.WriteLine("Total flavors before delete: {0}", iceCreamFlavors.Count);
            iceCreamFlavors.RemoveAt(2);
            System.Console.WriteLine("Total flavors after delete: {0}", iceCreamFlavors.Count);
            return iceCreamFlavors;
        }

        public static void UserInfoDict()
        {
            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            Random random = new Random();
            foreach (string name in names)
            {
                int randomNum = random.Next(0, names.Length);
                userInfo.Add(name, ListOfFlavors()[randomNum]);
            }
            foreach (KeyValuePair<string, string> item in userInfo)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }


        static void Main(string[] args)
        {
            // BasicArrays();
            MultiplicationTable();
            // ListOfFlavors();
            // UserInfoDict();
        }
    }
}
