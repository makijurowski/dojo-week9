using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray(Random random)
        {
            // Declare variables
            int[] randArr = new int[10];
            int arrSum = 0;
            int arrMin = 0;
            int arrMax = 0;
            // Iterate through empty array
            for (int i = 0; i < randArr.Length; i++) 
            {
                // Create a randomNum and add to my array
                int randomNum = random.Next(5, 25);
                randArr[i] = randomNum;
                // Add value of randomNum to total sum
                arrSum += randomNum;
            }
            // With array complete, calculate min and max values
            arrMin = randArr.Min();
            arrMax = randArr.Max();
            // Print output
            System.Console.WriteLine("My random array min val is {0}, max val is {1}, and the total sum of all values is {2}", arrMin, arrMax, arrSum);
            // Return the array
            return randArr;
        }

        public static string TossCoin(Random random)
        {
            System.Console.WriteLine("Tossing a coin!");
            // Declare a random variable with values of 0 or 1
            int randomToss = random.Next(0, 2);
            string result = "";
            // Store results of coin flip as a string
            if (randomToss == 0) {
                result = "Heads";
            }
            else {
                result = "Tails";
            }
            // Print result to console, then return
            System.Console.WriteLine(result);
            return(result);
        }

        public static double TossMultipleCoins(int num, Random random)
        {
            // Declare number variables as doubles to force decimals upon division
            double numHeads = 0;
            double numTails = 0;
            // Back-up forcing decimals for ratio division
            double ratio = 0.00d;
            string result = "";
            // Iterate through total number of coin flips
            for (int i = 0; i <= num; i++)
            {
                // Call TossCoin function to determine heads or tails
                result = TossCoin(random);
                if (result == "Heads") 
                {
                    // Add up the number of heads tosses
                    numHeads += 1;
                    System.Console.WriteLine("numHeads = {0}", numHeads);
                }
                else
                {
                    // Add up the number of tails tosses
                    numTails += 1;
                    System.Console.WriteLine("numTails = {0}", numTails);
                }
            }
            // Ratio determined by number of heads divided by total number of tosses
            ratio = (numHeads)/(num);
            // Print ratio to console and then return as double
            System.Console.WriteLine("Ratio of heads to total flips: {0}", ratio);
            return(ratio);
        }

        public static ArrayList Names()
        {
            // Create an array with given name values
            string[] namesArr = new string[5] {
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            // Shuffle array using Fisher-Yates-based Shuffle function
            string[] shuffledArr = Shuffle(namesArr);
            // Create an ArrayList (dynamic array) to filter results
            ArrayList filteredArr = new ArrayList();
            // Iterate through our shuffled array
            foreach (string name in shuffledArr)
            {
                // If the length of the name is over 5 chars, add to filteredArr
                if (name.Length > 5)
                {
                    filteredArr.Add(name);
                }
            }
            // Print to console contents of filteredArr
            foreach (string name in filteredArr)
            {
                System.Console.WriteLine(name);
            }
            return filteredArr;
        }

        // Shuffle function based on Fisher-Yates algorithm
        public static string[] Shuffle(string[] array)
        {
            // Declare variable for random
            Random random = new Random();
            // Iterate through array, starting from the end
            for(int i = (array.Length - 1); i > 0; i--)
            {
                // Swap values according to random number
                int index = random.Next(i);
                string temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
            // Return the now-shuffled array
            return array;
        }

        public static void Main(string[] args)
        {
            Random random = new Random();
            RandomArray(random);
            TossCoin(random);
            TossMultipleCoins(10, random);
            Names();
        }
    }
}
