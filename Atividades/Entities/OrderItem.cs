using System;
using System.Collections.Generic;
using System.Text;

namespace Atividades.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public Double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
