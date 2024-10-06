using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId {get; set;}
        public int EmployeeId {get; set;}
        public Employee? Employee {get; set;}
        public int CustomerId {get; set;}
        public Customer? Customer {get; set;}
        public DateTime? OrderExportDateTime {get; set;}
        public string? OrderNotice {get; set;}
        public List<Product>? Products {get; set;}
        public List<Order_Detail>? Details {get; set;}
    }
}