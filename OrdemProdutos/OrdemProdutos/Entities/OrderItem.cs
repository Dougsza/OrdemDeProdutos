using System;
using System.Collections.Generic;
using System.Text;

namespace OrdemProdutos.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }

        OrderItem() {

        }
        OrderItem(int quantity, double price) {
            Quantity = quantity;
            Price = price;
        }
        void subTotal(double price) {
            Price = price * Quantity;
        }

    }
}
