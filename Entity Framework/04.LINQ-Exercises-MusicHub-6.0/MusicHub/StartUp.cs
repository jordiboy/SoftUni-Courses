namespace MusicHub
{
    using System;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main()
        {
            using MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here
            const int producerId = 9;
            string result = ExportAlbumsInfo(context, producerId);
            Console.WriteLine(result);
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder sb = new StringBuilder();

            var albums = context
                .Albums
                .Where(a => a.ProducerId.HasValue && a.ProducerId.Value == producerId)
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy"),
                    ProducerName = a.Producer!.Name,
                    Songs = a
                        .Songs
                        .Select(s => new
                        {
                            SongName = s.Name,
                            SongPrice = s.Price,
                            SongWriter = s.Writer.Name,
                        })
                        .OrderByDescending(s => s.SongName)
                        .ThenBy(s => s.SongWriter)
                        .ToArray(),
                    AlbumPrice = a.Price,
                })
                .ToArray();

            albums = albums
                .OrderByDescending(a => a.AlbumPrice)
                .ToArray();

            foreach (var album in albums)
            {
                sb
                    .AppendLine($"-AlbumName: {album.AlbumName}")
                    .AppendLine($"-ReleaseDate: {album.ReleaseDate}")
                    .AppendLine($"-ProducerName: {album.ProducerName}")
                    .AppendLine("-Songs:");

                int index = 1;
                foreach (var song in album.Songs)
                {
                    sb
                        .AppendLine($"---#{index++}")
                        .AppendLine($"---SongName: {song.SongName}")
                        .AppendLine($"---Price: {song.SongPrice:f2}")
                        .AppendLine($"---Writer: {song.SongWriter}");
                }

                sb.AppendLine($"-AlbumPrice: {album.AlbumPrice:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}
