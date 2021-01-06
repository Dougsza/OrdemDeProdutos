using System;
using OrdemProdutos.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace OrdemProdutos.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() {

        }
        public Order(DateTime moment, OrderStatus status) {

        }
        public void addItem(OrderItem item) {
            Items.Add(item);
        }
        public void removeItem(OrderItem item) {
            Items.Remove(item);
        }
    }
}
