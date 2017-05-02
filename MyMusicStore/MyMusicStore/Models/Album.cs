using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        [Display(Name ="Url")]
        public string AlbumArtUrl { get; set; }

        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }

        [Display(Name = "Artist")]
        public string Name { get; set; }
    }

    public class Genre
    {
        public int GenreId { get; set; }

        [Display(Name = "Genre")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }

    public class Album_DBContext : DbContext
    {
        public Album_DBContext() : base("Albums_DB") { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}