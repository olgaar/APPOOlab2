using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Shop
    {
        
        public List<Book> ReturnAllBooks()
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand("Select * From Books", conn);
            var books = dbAccessor.ReturnBooks(cmd);

            dbAccessor.CloseConnection(conn);

            return books;

        }

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

            SqlCommand cmd = new SqlCommand("Select * From Books", conn);
           // dbAccessor.PrintBooks(cmd);

            dbAccessor.CloseConnection(conn);
        }

        public void ShowBookById(int id)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("Select * From Books WHERE id = {0} ", id), conn);
           // dbAccessor.PrintBooks(cmd);

            dbAccessor.CloseConnection(conn);
        }

        public void ChangePrice(int id, int price)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET price = {1} WHERE id = {0}", id, price), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }
        public void ChangeName(int id, string name)
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET name = {1} WHERE id = {0}", id, name), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }
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
    
