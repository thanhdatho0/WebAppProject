using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order_Detail
    {
        public int OrderId {get; set;}
        public Order? Order {get; set;}
        public int ProductId {get; set;}
        public Product? Product {get; set;}
        public int Amount {get; set;}
    }
}