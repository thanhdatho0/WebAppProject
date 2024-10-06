using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Models
{
    public class Company
    {
        [Key]
        public int CompanyId {get; set;}
        public string? CompanyName {get; set;}
        public string? Address {get; set;}
        public string? Slogan {get; set;}
        [Column(TypeName = "DateTime")]
        public DateTime? FoundDate {get; set;}
        public string? Description {get; set;}
        public List<Department>? Departments {get; set;}
    }
}