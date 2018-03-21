using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class CatalogPrinter
    {
        public virtual void PrintClientFields(SqlCommand cmd)
        {
            Console.WriteLine("\n***** USER CATALOG *****");


            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} ",
                    // call the objects from their index
                    reader[0], reader[1], reader[2]));
                }
            }
        }
        public void PrintBooksForManager(SqlCommand cmd)
        {
            Console.WriteLine("\n***** Manager CATALOG *****");
            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    Console.WriteLine(String.Format("{0} \t | {1} \t | {2} \t | {3}",
                    // call the objects from their index
                    reader[0], reader[1], reader[2], reader[3]));
                }
            }
        }
    }
}
