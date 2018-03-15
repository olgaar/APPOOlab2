using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    interface ICatalogChangeble
    {
        void ChangePrice(int id, int price);
        void ChangeName(int id, string name);
    }
}
