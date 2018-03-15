using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    interface IBookControllable
    {
        void AddNewBook(Book book);
        void DeleteBookById(int id);
    }
}
