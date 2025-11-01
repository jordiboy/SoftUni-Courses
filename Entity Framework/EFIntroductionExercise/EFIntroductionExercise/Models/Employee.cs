using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUni.Models
{
    public class Employee
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? MiddleName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string JobTitle { get; set; } = null!;
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Employees")]
        public virtual Department Department { get; set; } = null!;

        [Column("ManagerID")]
        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("InverseManager")]
        public virtual Employee? Manager { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime HireDate { get; set; }

        [Column(TypeName = "decimal(15, 4)")]
        public decimal Salary { get; set; }

        [Column("AddressID")]
        public int? AddressId { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Employees")]
        public virtual Address? Address { get; set; }

        [InverseProperty("Manager")]
        public virtual ICollection<Department> Departments { get; set; }
            = new HashSet<Department>();

        [InverseProperty("Manager")]
        public virtual ICollection<Employee> InverseManager { get; set; }
            = new HashSet<Employee>();

        //[ForeignKey("EmployeeId")]
        //[InverseProperty("EmployeesProjects")]
        public virtual ICollection<EmployeeProject> EmployeesProjects { get; set; }
            = new HashSet<EmployeeProject>();
    }
}
