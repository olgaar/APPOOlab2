using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class DbAccessor
    {
        public SqlConnection OpenConnection()
        {
            string connStr = "Data Source=BURGUNDY;Initial Catalog=BooksForAppoo;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            
            return conn;
        }

        public void PrintBooks(SqlCommand cmd)
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
        public void PrintBooksForCustomer(SqlCommand cmd)
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

        public List<Book> ReturnBooks(SqlCommand cmd)
        {
            List<Book> books = new List<Book>();

            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
               
                // while there is another record present
                while (reader.Read())
                {
                    Book book = new Book();
                                   
                    book.setId(reader.GetInt32(0));
                    book.setName(reader.GetString(1));
                    book.setPrice(reader.GetInt32(2));
                    book.setQuantity(reader.GetInt32(3));
                    books.Add(book);
                }
            }
            return books;
        }

        

        public void CloseConnection(SqlConnection conn)
        {
            conn.Close();
            conn.Dispose();
        }

    }
}
