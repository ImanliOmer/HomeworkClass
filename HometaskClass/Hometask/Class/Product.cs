using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask.Class
{
     public class Product
    {
        public int Number;
        public string Name;
        public double Price;
        public int Count;

        public Product(int number, string name, double price)
        {
            Number = number;
            Name = name;
            Price = price;
            
        }

    }
}
