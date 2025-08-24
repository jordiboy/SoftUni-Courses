
namespace MusicHub.Data.Models
{
    public class Performer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public decimal NetWorth { get; set; }

        public virtual ICollection<SongPerformer> PerformerSongs { get; set; } 
            = new HashSet<SongPerformer>();
    }
}
