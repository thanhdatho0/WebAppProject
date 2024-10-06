using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId {get; set;}
        public string? DepartmentName {get; set;}
        public int ManagerId {get; set;}
        public int CompanyId {get; set;}
        public Company? Company {get; set;}
        public List<Employee>? Employees {get; set;}
    }
}