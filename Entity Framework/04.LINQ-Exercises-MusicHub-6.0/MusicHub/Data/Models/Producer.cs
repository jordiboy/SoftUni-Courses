
namespace MusicHub.Data.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Pseudonym { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Album> Albums { get; set; } 
            = new HashSet<Album>();
    }
}
