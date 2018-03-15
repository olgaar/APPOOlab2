using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Stock: IBookControllable, IQuantityUpdatable
    {
        

        public void ChangeQuantity(int id, int quantity)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET quantity = {1} WHERE id = {0}", id, quantity), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }

        public void AddNewBook(Book book)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO [BooksForAppoo].[dbo].[Books] VALUES({0}, \'{1}\', {2}, {3});", book.getId(), book.getName(), book.getPrice(), book.getQuantity()), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }

        public void DeleteBookById(int id)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("Delete from [BooksForAppoo].[dbo].[Books] WHERE id = {0}", id), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }
    }
}
