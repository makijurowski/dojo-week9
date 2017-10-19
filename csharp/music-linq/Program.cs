using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication {
    public class Program {
        public static void Main (string[] args) {
            // Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson ();
            List<Group> Groups = JsonToFile<Group>.ReadJson ();


            // ========================================================
            // Solve all of the prompts below using various LINQ queries
            // ========================================================


            // 1. There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> challenge1 = Artists.Where (artist => artist.Hometown == "Mount Vernon");

            foreach (Artist artist in challenge1) {
                System.Console.WriteLine ("\n========CHALLENGE 1=========");
                System.Console.WriteLine ("Find artist from Mount Vernon");
                System.Console.WriteLine ("----------------------------\n");
                System.Console.WriteLine ("ARTIST NAME: {0}\nREAL NAME: {1}\nAGE: {2}\n", 
                                          artist.ArtistName, 
                                          artist.RealName, 
                                          artist.Age);
            }


            // 2. Who is the youngest artist in our collection of artists?
            IEnumerable<Artist> challenge2 = from artist in Artists
                                             orderby artist.Age ascending
                                             select artist;

            System.Console.WriteLine ("\n=========CHALLENGE 2=========");
            System.Console.WriteLine ("The youngest artist in collection");
            System.Console.WriteLine ("-----------------------------\n");
            System.Console.WriteLine ("ARTIST NAME: {0}\nREAL NAME: {1}\nAGE: {2}\n", 
                                      challenge2.First().ArtistName, 
                                      challenge2.First().RealName, 
                                      challenge2.First().Age);


            // 3. Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> challenge3 = Artists.Where (artist => artist.RealName.Contains ("William"));

            System.Console.WriteLine ("\n=========CHALLENGE 3=========");
            System.Console.WriteLine ("Real name contains 'William'");
            System.Console.WriteLine ("-----------------------------\n");

            int count = 1;
            foreach (Artist artist in challenge3) {
                System.Console.WriteLine ("{0}. ARTIST NAME: {1}\n   REAL NAME: {2}\n", 
                                          count, 
                                          artist.ArtistName, 
                                          artist.RealName);
                count += 1;
            }

            // 4. Display all groups with names less than 8 characters in length.
            IEnumerable<Group> challenge4 = Groups.Where (group => group.GroupName.Length < 8);

            System.Console.WriteLine ("\n=========CHALLENGE 4=========");
            System.Console.WriteLine ("Groups with names less than 8 characters");
            System.Console.WriteLine ("-----------------------------\n");

            count = 1;
            foreach (Group group in challenge4) {
                System.Console.WriteLine ("{0}. GROUP NAME: {1} ({2} characters)\n",
                                          count,
                                          group.GroupName,
                                          group.GroupName.Length);
                count += 1;
            }


            // 5. Display the 3 oldest artist from Atlanta
            var challenge5 = (from artist in Artists 
                              where artist.Hometown.Equals ("Atlanta") 
                              orderby artist.Age descending 
                              select new {
                                  artistName = artist.ArtistName,
                                  realName = artist.RealName,
                                  hometown = artist.Hometown,
                                  age = artist.Age}).Take (3);

            System.Console.WriteLine ("\n=========CHALLENGE 5=========");
            System.Console.WriteLine ("Three oldest artists from Atlanta");
            System.Console.WriteLine ("-----------------------------\n");

            count = 1;
            foreach (var artist in challenge5) {
                System.Console.WriteLine ("{0}. ARTIST NAME: {1}\n   REAL NAME: {2}\n   HOMETOWN: {3}\n   AGE: {4}\n", 
                                          count, 
                                          artist.artistName, 
                                          artist.realName, 
                                          artist.hometown, 
                                          artist.age);
                count += 1;
            }


            // 6. (Optional) Display the Group Name of all groups that have members that are not from New York City
            var challenge6 = (from artist in Artists 
                              where!artist.Hometown.Contains ("New York City") 
                              select artist.GroupId).Distinct ();

            System.Console.WriteLine ("\n=========CHALLENGE 6=========");
            System.Console.WriteLine ("Groups without NYC members");
            System.Console.WriteLine ("-----------------------------\n");

            count = 1;
            foreach (var item in challenge6) {
                var groups = from each in Groups
                where each.Id.Equals (item)
                select each.GroupName;

                foreach (string group in groups) {
                    System.Console.WriteLine ("{0}. GROUP NAME: {1}\n", 
                                              count, 
                                              group);
                    count += 1;
                }
            }


            // 7. (Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            var challenge7 = (from artist in Artists 
                              join groupList in Groups 
                              on artist.GroupId equals groupList.Id 
                              where groupList.GroupName == "Wu-Tang Clan"
                              select new {
                                  artistName = artist.ArtistName,
                                  groupName = groupList.GroupName
                              });

            System.Console.WriteLine ("\n=========Challenge 7=========");
            System.Console.WriteLine ("All Wu-Tang Clan members");
            System.Console.WriteLine ("-----------------------------\n");

            count = 1;
            foreach (var artist in challenge7) {
                System.Console.WriteLine ("{0}. ARTIST NAME: {1} (from {2})\n", 
                                          count, 
                                          artist.artistName, 
                                          artist.groupName);
                count += 1;
            }
        }
    }
}