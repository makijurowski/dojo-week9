using System;
using System.Collections.Generic;
using DbConnection;

namespace crud_with_mysql
{
    class Program
    {
        public static void Create()
        {
            string FirstName = ""; 
            string LastName = "";
            string FavoriteNumber = "";

            // Prompt user to add new entry
            System.Console.WriteLine("\nADD NEW RECORD TO TABLE");
            System.Console.WriteLine("\nPlease enter your first name:");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("\nPlease enter your last name:");
            LastName = System.Console.ReadLine();
            System.Console.WriteLine("\nPlease enter your favorite number:");
            FavoriteNumber = System.Console.ReadLine();

            string query = string.Format("INSERT INTO Users (FirstName, LastName, FavoriteNumber) VALUES('{0}', '{1}', {2});", FirstName, LastName, FavoriteNumber);

            DbConnector.Execute(query);

            Read();
        }

        public static void Read()
        {
            // Show all entries
            var results = new List<Dictionary<string, object>>(DbConnector.Query("SELECT * FROM Users;"));
            int totalRecords = results.Count;

            System.Console.WriteLine("\nCURRENT DATA FROM TABLE ({0} Entries)\n", totalRecords);
            foreach (Dictionary<string, object> entry in results)
            {
                foreach (KeyValuePair<string, object> dict in entry)
                {
                    System.Console.WriteLine("{0}: {1}", dict.Key.ToUpper(), dict.Value);
                }
                System.Console.WriteLine("");
            }
        }

        public static void Update(int entryID)
        {
            string FirstName = "";
            string LastName = "";
            string FavoriteNumber = "";

            // Display current entry info
            string findQuery = string.Format("SELECT * FROM Users WHERE id = {0};", entryID);
            var oldResult = new List<Dictionary<string, object>>(DbConnector.Query(findQuery));
            System.Console.WriteLine("\nCURRENT DATA FOR ENTRY {0}\n", entryID);
            foreach (Dictionary<string, object> entry in oldResult)
            {
                foreach (KeyValuePair<string, object> dict in entry)
                {
                    System.Console.WriteLine("{0}: {1}", dict.Key.ToUpper(), dict.Value);
                }
                System.Console.WriteLine("");
            }

            // Prompt user to update the entry
            System.Console.WriteLine("\nUPDATE RECORD FROM TABLE");
            System.Console.WriteLine("\nPlease enter your first name:");
            FirstName = System.Console.ReadLine();
            System.Console.WriteLine("\nPlease enter your last name:");
            LastName = System.Console.ReadLine();
            System.Console.WriteLine("\nPlease enter your favorite number:");
            FavoriteNumber = System.Console.ReadLine();

            string updateQuery = string.Format("UPDATE Users SET FirstName = \"{0}\", LastName = \"{1}\", FavoriteNumber = \"{2}\" WHERE id = {3};", FirstName, LastName, FavoriteNumber, entryID);
            DbConnector.Execute(updateQuery);

            // Display updated entry
            var newResult = new List<Dictionary<string, object>>(DbConnector.Query(findQuery));
            System.Console.WriteLine("\nUPDATED DATA FOR ENTRY {0}\n", entryID);
            foreach (Dictionary<string, object> entry in newResult)
            {
                foreach (KeyValuePair<string, object> dict in entry)
                {
                    System.Console.WriteLine("{0}: {1}", dict.Key.ToUpper(), dict.Value);
                }
                System.Console.WriteLine("");
            }
        }

        public static void Destroy(int entryID)
        {
            // Delete the specified entry
            string destroyQuery = string.Format("DELETE FROM Users WHERE id = {0};", entryID);
            DbConnector.Execute(destroyQuery);
            System.Console.WriteLine("\nSuccessfully deleted entry no. {0}", entryID);
            Read();
        }
        

        static void Main(string[] args)
        {
            // Read();

            // Create();
            
            // Update(2);

            // Destroy(2);
        }
    }
}
