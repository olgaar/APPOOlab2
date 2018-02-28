using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Manager:Shop
    {
        public int managerId;

        public Manager(int managerId)
        {
            this.managerId = managerId;
        }
    }
}
