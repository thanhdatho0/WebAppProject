using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Employee : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId {get; set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary {get; set;}
        [Column(TypeName = "DateTime")]
        public DateTime StartDate {get; set;}
        public int ContractUpTo {get; set;}
        public string ParentNumber {get; set;} = string.Empty;
        public int? DepartmentId {get; set;}
        public Department? Department {get; set;}
    }
}