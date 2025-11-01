using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUni.Models
{
    public class Department
    {
        [Key]
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column("ManagerID")]
        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("Departments")]
        public virtual Employee Manager { get; set; } = null!;

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
