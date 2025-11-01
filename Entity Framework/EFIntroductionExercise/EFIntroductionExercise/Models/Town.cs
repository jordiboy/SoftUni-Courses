using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SoftUni.Models
{
    public class Town
    {
        [Key]
        [Column("TownID")]
        public int TownId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("Town")]
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
    }
}
