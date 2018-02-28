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

            Admin admin = new Admin(114589723, 12);
            admin.ShowCatalog();
            admin.BuyBook(2);
            admin.ShowCatalog();
            admin.ShowBookById(3);

            Manager manager = new Manager(123654);
            manager.ChangePrice(1, 200);
            manager.ShowCatalog();
            Book book = new Book();
            book.setId(5); book.setName("Tom Sawyer Mark Twain"); book.setPrice(90); book.setQuantity(30);
            manager.AddNewBook(book);
            manager.ShowCatalog();
            
            Customer customer = new Customer(3, "batman");
            customer.DeleteBookById(5);
            customer.ShowCatalog();
            var books= customer.ReturnAllBooks();

        }
    }
}
