using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Admin:Shop
    {
        public int idnp;
        public int computerId;
        public Admin(int idnp, int computerId)
        {
            this.idnp = idnp;
            this.computerId = computerId;
        }
    }
}
