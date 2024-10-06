using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Employee : Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int employeeId;
        private decimal salary;
        [Column(TypeName = "decimal(18,2)")]
        private DateTime startDate;
        private int contractUpTo;
        private string parentNumber = string.Empty;
        private int departmentId;
        private Department department = new();

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int ContractUpTo { get => contractUpTo; set => contractUpTo = value; }
        public string ParentNumber { get => parentNumber; set => parentNumber = value; }
        public int DepartmentID { get => departmentId; set => departmentId = value; }
        public Department Department { get => department; set => department = value; }
    }
}