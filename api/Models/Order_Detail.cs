using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order_Detail
    {
        private int orderId;
        private Order order = new();
        private int productId;
        private Product product = new();
        private int amount = 0;

        public int OrderId { get => orderId; set => orderId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int Amount { get => amount; set => amount = value; }
        public Order Order { get => order; set => order = value; }
        public Product Product { get => product; set => product = value; }
    }
}