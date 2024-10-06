using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order
    {
        private int orderId;
        private int employeeId;
        private Employee employee = new();
        private int customerId;
        private Customer customer = new();
        private DateTime orderExportDateTime = new();
        private List<Order_Detail> details = [];

        public int OrderId { get => orderId; set => orderId = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public DateTime OrderExportDateTime { get => orderExportDateTime; set => orderExportDateTime = value; }
        public List<Order_Detail> Details { get => details; set => details = value; }
    }
}