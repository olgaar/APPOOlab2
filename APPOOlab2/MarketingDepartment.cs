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
        DbAccessor dbAccessor= new DbAccessor();
        CatalogPrinter catalogPrinter= new CatalogPrinter();
       
        public void ShowCatalog()
        {
            var conn = dbAccessor.OpenConnection();
            var cmd = dbAccessor.ExecuteQuery("Select * From Books", conn);
            catalogPrinter.PrintBooksForManager(cmd);
            dbAccessor.CloseConnection(conn);
        }

        public void ShowBookById(int id)
        {
            var conn = dbAccessor.OpenConnection();
            var cmd = dbAccessor.ExecuteQuery(String.Format("Select * From Books WHERE id = {0} ", id), conn);
            catalogPrinter.PrintBooksForManager(cmd);
            dbAccessor.CloseConnection(conn);
        }

        public void ChangePrice(int id, int price)
        {
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET price = {1} WHERE id = {0}", id, price), conn);
            dbAccessor.CloseConnection(conn);
        }

        public void ChangeName(int id, string name)
        {
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET name = \'{1}\' WHERE id = {0}", id, name), conn);
            dbAccessor.CloseConnection(conn);

        }

      }
}
