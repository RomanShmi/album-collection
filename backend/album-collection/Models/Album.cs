using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Album
    {

        /*
           album
   - id
   - title
   - image
   - artist
   - songs (either as a string to be separated, or see below)
   - reviews
   - record label 
        
         
         */
        public int Id { get;  set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public string Image { get; set; }

        public string Labe { get; set; }

        public virtual List<Review> Reviews { get; set; }
        public virtual List<Song> Songs  { get; set; }






    }
}
