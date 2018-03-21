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
        DbAccessor dbAccessor = new DbAccessor();
        CatalogPrinter catalogPrinter= new CatalogPrinter();        
       
        public void BuyBook(int id)
        {          
            var conn = dbAccessor.OpenConnection();
            dbAccessor.ExecuteQuery(String.Format("UPDATE[BooksForAppoo].[dbo].[Books] SET quantity = quantity - 1 WHERE id = {0}", id), conn);
            dbAccessor.CloseConnection(conn);
        }

        public void ShowCatalog()
        {
           
            var conn = dbAccessor.OpenConnection();
            Console.WriteLine("WELCOME TO OUR SHOP!");
            var cmd = dbAccessor.ExecuteQuery("Select id, name, price From [BooksForAppoo].[dbo].[Books]", conn);
            catalogPrinter.PrintClientFields(cmd);
            dbAccessor.CloseConnection(conn);
        }

        public void ShowBookById(int id)
        {
            var conn = dbAccessor.OpenConnection();
            var cmd = dbAccessor.ExecuteQuery(String.Format("Select * From Books WHERE id = {0} ", id), conn);
            catalogPrinter.PrintClientFields(cmd);
            dbAccessor.CloseConnection(conn);
        }
    }
}
