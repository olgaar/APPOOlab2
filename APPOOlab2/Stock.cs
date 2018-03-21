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
        DbAccessor dbAccessor = new DbAccessor();

        public void ChangeQuantity(int id, int quantity)
        {
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET quantity = {1} WHERE id = {0}", id, quantity), conn);            
            dbAccessor.CloseConnection(conn);

        }

        public void AddNewBook(Book book)
        {
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("INSERT INTO [BooksForAppoo].[dbo].[Books] VALUES({0}, \'{1}\', {2}, {3});", book.getId(), book.getName(), book.getPrice(), book.getQuantity()), conn);
            dbAccessor.CloseConnection(conn);

        }

        public void DeleteBookById(int id)
        {
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("Delete from [BooksForAppoo].[dbo].[Books] WHERE id = {0}", id), conn);
            dbAccessor.CloseConnection(conn);

        }
    }
}
