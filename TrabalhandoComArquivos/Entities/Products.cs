using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComArquivos.Entities
{
    class Products
    {
        public string Name { set; get; }
        public double Price { set; get; }

        public int Quantity { set; get; }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }

    }
}
