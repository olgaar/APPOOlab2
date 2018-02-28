using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public class Book
    {
        private int id;
        private string name;
        private int price;
        private int quantity;

        public int getId() => id;
        public string getName() => name;
        public int getPrice() => price;
        public int getQuantity() => quantity;

        public void setId(int newId) => id= newId;
        public void setName(string newName) => name = newName;
        public void setPrice(int newPrice) => price = newPrice;
        public void setQuantity(int newQuantity) => quantity = newQuantity;


    }
}
