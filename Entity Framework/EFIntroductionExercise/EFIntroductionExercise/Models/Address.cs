using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUni.Models
{
    public class Address
    {
        [Key]
        [Column("AddressID")]
        public int AddressId { get; set; }

        [StringLength(100)]
        [Unicode(false)]
        public string AddressText { get; set; } = null!;

        [Column("TownID")]
        public int? TownId { get; set; }

        [ForeignKey("TownId")]
        [InverseProperty("Addresses")]
        public virtual Town? Town { get; set; }

        [InverseProperty("Address")]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
