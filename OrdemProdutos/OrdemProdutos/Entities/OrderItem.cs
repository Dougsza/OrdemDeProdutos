using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemProdutos.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        Product Product { get; set; }

        public OrderItem() {

        }
        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
       public void subTotal(double price) {
            Price = price * Quantity;
        }

    }
}
