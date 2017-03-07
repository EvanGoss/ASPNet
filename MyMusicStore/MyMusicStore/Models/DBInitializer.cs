using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyMusicStore.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<Album_DBContext>
    {
        protected override void Seed(Album_DBContext context)
        {
            SeedGenres().ForEach(g => context.Genres.Add(g));
            SeedArtists().ForEach(a => context.Artists.Add(a));
            SeedAlbums().ForEach(m => context.Albums.Add(m));
        }

        // Seed Genres
        private static List<Genre> SeedGenres()
        {
            var genres = new List<Genre>
            {
                new Genre
                {
                    GenreId = 1,
                    Name = "Latin",
                    Description = "music from Latin America and other Caribbean countries"
                },
                new Genre
                {
                    GenreId = 2,
                    Name = "Pop",
                    Description = "The term pop is originally derived form an abbreviation of popular"
                },
                new Genre
                {
                    GenreId = 3,
                    Name = "Country",
                    Description = "Originated in the rural regions of southern United States"
                },
            };
            return genres;

        }
        
        // Seed Artists
        private static List<Artist> SeedArtists()
        {
            var artists = new List<Artist>
            {
                new Artist { ArtistId=1, Name="Ricky Martin" },
                new Artist { ArtistId=2, Name="Michael Jackson" },
                new Artist { ArtistId=3, Name="Johnny Cash" },
            };
            return artists;
        }

        // Seed Albums
        private static List<Album> SeedAlbums()
        {
            var albums = new List<Album>
            {
                new Album
                {
                    Title = "Ricky Martin",
                    ArtistId = 1,
                    GenreId = 1,
                    Price = 12.99M
                },
                new Album
                {
                    Title = "Thriller",
                    ArtistId = 2,
                    GenreId = 2,
                    Price = 9.19M
                },
                new Album
                {
                    Title = "I Walk the Line",
                    ArtistId = 3,
                    GenreId = 3,
                    Price = 9.19M
                },
            };
            return albums;
        }
    }
}