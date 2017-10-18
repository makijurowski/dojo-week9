using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?

            IEnumerable<Artist> Challenge1 = Artists.Where( artist => artist.Hometown == "Mount Vernon" );

            foreach(Artist artist in Challenge1)
            {
                System.Console.WriteLine("\n========CHALLENGE 1=========");
                System.Console.WriteLine("Find artist from Mount Vernon");
                System.Console.WriteLine("----------------------------\n");
                System.Console.WriteLine("REAL NAME: {0}\nAGE: {1}", artist.RealName, artist.Age);
            }

            //Who is the youngest artist in our collection of artists?
            IEnumerable<Artist> Challenge2 = from artist in Artists
                                             orderby artist.Age ascending
                                             select artist;

            System.Console.WriteLine("\n=========CHALLENGE 2=========");
            System.Console.WriteLine("The youngest artist in collection");
            System.Console.WriteLine("-----------------------------\n");
            // System.Console.WriteLine("NAME: {0}\nAGE: {1}", artist.RealName, artist.Age);
            System.Console.WriteLine("ARTIST NAME: {0}", Challenge2.First().ArtistName);

            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> Challenge3 = Artists.Where( artist => artist.RealName.Contains("William") );
            
            System.Console.WriteLine("\n=========CHALLENGE 3=========");
            System.Console.WriteLine("Real name contains 'William'");
            System.Console.WriteLine("-----------------------------\n");
            int count = 1;
            foreach (Artist artist in Challenge3)
            {
                System.Console.WriteLine("{0}. ARTIST NAME: {1}\n   REAL NAME: {2}\n", count, artist.ArtistName, artist.RealName);
                count += 1;
            }

            //Display the 3 oldest artist from Atlanta

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
