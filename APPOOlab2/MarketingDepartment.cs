using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class MarketingDepartment : IShowable, ICatalogChangeble
    {
        
       
        public void ShowCatalog()
        {
            DbAccessor dbAccessor = new DbAccessor();
            var conn = dbAccessor.OpenConnection();

            SqlCommand cmd = new SqlCommand("Select * From Books", conn);
            dbAccessor.PrintBooks(cmd);

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

            SqlCommand cmd = new SqlCommand(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET name = \'{1}\' WHERE id = {0}", id, name), conn);
            cmd.ExecuteNonQuery();

            dbAccessor.CloseConnection(conn);

        }

      }
}
