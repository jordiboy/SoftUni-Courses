namespace MusicHub.Data
{
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;

    public class MusicHubDbContext : DbContext
    {
        public MusicHubDbContext()
        {
        }

        public MusicHubDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<SongPerformer> SongsPerformers { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Song>(e =>
                {
                    e.HasKey(s => s.Id);

                    e
                    .Property(s => s.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                    //Relations
                    e
                    .HasOne(s => s.Album)
                    .WithMany(a => a.Songs)
                    .HasForeignKey(s => s.AlbumId);

                    e
                    .HasOne(s => s.Writer)
                    .WithMany(w => w.Songs)
                    .HasForeignKey(s => s.WriterId);
                });

            builder
                .Entity<Album>(e =>
                {
                    e.HasKey(s => s.Id);
                    e
                    .Property(s => s.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                    // Relations

                    e
                    .HasOne(a => a.Producer)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(a => a.ProducerId);
                });

            builder
                .Entity<Performer>(e =>
                {
                    e.HasKey(p => p.Id);
                    e
                    .Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);
                    e
                    .Property(p => p.LastName)
                    .IsRequired()
                    .HasMaxLength(20);
                });

            builder
                .Entity<Producer>(e =>
                {
                    e.HasKey(p => p.Id);
                    e
                    .Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(30);
                });

            builder
                .Entity<Writer>(e =>
                {
                    e.HasKey(w => w.Id);
                    e
                    .Property(w => w.Name)
                    .IsRequired()
                    .HasMaxLength(20);
                });

            builder
                .Entity<SongPerformer>(e =>
                {
                    e.HasKey(sp => new { sp.SongId, sp.PerformerId });

                    // Relations

                    e
                    .HasOne(sp => sp.Song)
                    .WithMany(s => s.SongPerformers)
                    .HasForeignKey(sp => sp.SongId);

                    e
                    .HasOne(sp => sp.Performer)
                    .WithMany(p => p.PerformerSongs)
                    .HasForeignKey(sp => sp.PerformerId);
                });
                        

        }
    }
}
