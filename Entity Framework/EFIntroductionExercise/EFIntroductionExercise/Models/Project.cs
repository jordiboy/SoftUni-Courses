using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUni.Models
{
    public class Project
    {
        [Key]
        [Column("ProjectID")]
        public int ProjectId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        //[ForeignKey("ProjectId")]
        //[InverseProperty("EmployeesProjects")]
        public virtual ICollection<EmployeeProject> EmployeesProjects { get; set; } 
            = new HashSet<EmployeeProject>();
    }
}
