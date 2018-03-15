using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.setId(5); book.setName("Tom Sawyer Mark Twain"); book.setPrice(90); book.setQuantity(30);


            Stock stock = new Stock();
            stock.DeleteBookById(5);
            stock.AddNewBook(book);
            stock.ChangeQuantity(5, 20);            

            MarketingDepartment manager = new MarketingDepartment();
            manager.ChangePrice(1, 100);
            manager.ChangeName(5, "Tommy");
            manager.ShowCatalog();
            manager.ShowBookById(1);
           
            
            
            ClientInterface customer = new ClientInterface();
            customer.ShowCatalog();
            customer.BuyBook(5);
            customer.ShowCatalog();

            manager.ShowCatalog();
            stock.DeleteBookById(5);
            manager.ShowCatalog();
            

        }
    }
}
