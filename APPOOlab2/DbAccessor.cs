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

        public SqlCommand ExecuteQuery(String query, SqlConnection conn)
        {
                      
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return cmd;
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
