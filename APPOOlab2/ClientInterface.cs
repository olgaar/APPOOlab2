using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class ClientInterface:IShowable, IBuyable
    {
        

       
        public void BuyBook(int id)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET quantity = quantity - 1 WHERE id = {0}", id), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }

        public void ShowCatalog()
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();
            Console.WriteLine("WELCOME TO OUR SHOP!");
            SqlCommand cmd = new SqlCommand("Select id, name, price From [BooksForAppoo].[dbo].[Books]", conn);
            dbAccessor.PrintBooksForCustomer(cmd);

            dbAccessor.CloseConnection(conn);
        }

        public void ShowBookById(int id)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("Select * From Books WHERE id = {0} ", id), conn);
            dbAccessor.PrintBooks(cmd);

            dbAccessor.CloseConnection(conn);
        }
    }
}
