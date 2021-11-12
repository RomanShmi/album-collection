using album_collection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection
{
    public class AlbumsContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public IConfiguration Configuration;
        public AlbumsContext(IConfiguration configuration) 
        {
            Configuration = configuration;
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
         var connectionString =Configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
    }
      
        
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Artist>().HasData(
                new Artist() { Id = 1, Name = "artist1" },
                     new Artist() { Id = 2, Name = "artist2" },
                          new Artist() { Id = 3, Name = "artist3" }
                );

            modelbuilder.Entity<Album>().HasData(
                new Album() {Id=1, Title="album1", ArtistId=1},
                 new Album() { Id = 2, Title = "album2", ArtistId=2 },
                  new Album() { Id = 3, Title = "album3", ArtistId=3}

                );
          

            modelbuilder.Entity<Song>().HasData(
                new Song() { Id = 1, Title = "albom1song1", AlbumId = 1 },
                  new Song() { Id = 2, Title = "albom1song2", AlbumId = 1 },
                    new Song() { Id = 3, Title = "albom2song1", AlbumId = 2 },
                      new Song() { Id = 4, Title = "albom2song2", AlbumId = 2 },
                        new Song() { Id = 5, Title = "albom3song1", AlbumId = 3 }
                        );

            modelbuilder.Entity<Review>().HasData(
                new Review() { Id = 1, AlbumId = 1, Name = "name1", ReviewContent = "review for albom 1" },
                  new Review() { Id = 2, AlbumId = 1, Name = "name2", ReviewContent = "review for albom 1" },
                    new Review() { Id = 3, AlbumId = 2, Name = "name3", ReviewContent = "review for albom 2" },
                      new Review() { Id = 4, AlbumId = 3, Name = "name4", ReviewContent = "review for albom 3" });
         base.OnModelCreating(modelbuilder);
        }
    }
}
