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
                new Artist() { Id = 1, Name = "Pink Floyd" },
                     new Artist() { Id = 2, Name = "The Rolling Stones" },
                          new Artist() { Id = 3, Name = "Britney Spears" },
                                new Artist() { Id = 4, Name = "Lady Gaga"},
                                    new Artist() { Id = 5, Name = "Jay-Z"}
                );

            modelbuilder.Entity<Album>().HasData(
                new Album() {Id=1, Title="The Wall", ArtistId=1, Image= "https://1071theboss.com/wp-content/uploads/2020/05/1091.jpg" },
                 new Album() { Id = 2, Title = "The Rolling Stones", ArtistId=2, Image= "https://www.udiscovermusic.com/wp-content/uploads/2017/04/The-Rolling-Stones-Debut-Album.jpg" },
                  new Album() { Id = 3, Title = "Oops!...I Did It Again", ArtistId=3, Image="https://i.pinimg.com/originals/8a/e8/8a/8ae88a537aefdbb5dc3347554601b330.jpg" },
                     new Album() { Id = 4, Title = "Born This Way", ArtistId = 4, Image = "https://target.scene7.com/is/image/Target/GUEST_0c04bcc2-b529-4b14-9a43-5122f7c1b379?wid=325&hei=325&qlt=80&fmt=webp" },
                        new Album() { Id = 5, Title = "Reasonable Doubt", ArtistId = 5, Image = "https://images.complex.com/complex/images/c_fill,dpr_auto,f_auto,q_auto,w_1400/fl_lossy,pg_1/l1c9h415wrvx1bg3uacd/reasonable-doubt?fimg-client-default" }

                );
          

            modelbuilder.Entity<Song>().HasData(
                new Song() { Id = 1, Title = "Another Brick In The Wall", AlbumId = 1 },
                new Song() { Id = 2, Title = "Goodbye Blue Sky", AlbumId = 1 },
                    new Song() { Id = 3, Title = "Route 66", AlbumId = 2 },
                    new Song() { Id = 4, Title = "Little By Little", AlbumId = 2 },
                        new Song() { Id = 5, Title = "Oops!...I Did It Again", AlbumId = 3 },
                        new Song() { Id = 6, Title = "Lucky", AlbumId = 3 },
                            new Song() { Id = 7, Title = "Born This Way", AlbumId = 4 },
                            new Song() { Id = 8, Title = "Judas", AlbumId = 4 },
                                new Song() { Id = 9, Title = "Can't Knock The Hustle", AlbumId = 5 },
                                new Song() { Id = 10, Title = "Feelin' It", AlbumId = 5 }
                        );

            modelbuilder.Entity<Review>().HasData(
                new Review() { Id = 1, AlbumId = 1, Name = "Jaxxon", ReviewContent = "The Wall is not just classic stoner music but also great for those of us who are interested in music that challenges societal norms and has a great rhythm to each piece." },
                  new Review() { Id = 2, AlbumId = 2, Name = "Eli", ReviewContent = "4/5 :)" },
                    new Review() { Id = 3, AlbumId = 3, Name = "Dawna", ReviewContent = "FREE BRITNEY!!!!" },
                      new Review() { Id = 4, AlbumId = 4, Name = "Roman", ReviewContent = "Gr8 Album" },
                        new Review() { Id = 4, AlbumId = 5, Name = "Jay", ReviewContent = "Best rapper ever!!!! 10/10 Recommend" }
                      );
         base.OnModelCreating(modelbuilder);
        }
    }
}
