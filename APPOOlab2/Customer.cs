using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Customer:Shop
    {
        public int customerId;
        public string login;

        public Customer(int id, string login)
        {
            this.customerId = id;
            this.login = login;
        }
    }
}
