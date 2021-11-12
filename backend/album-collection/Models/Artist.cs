using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        /*
         artist
           - id
           - name
           - image
           - albums
           - any other pertinent info. which could include:
              - age
              - record label
              - hometown
         */

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image{ get; set; }

        public string Origin { get; set; }
        public virtual List<Album> Albums { get; set; }


    }
}
