using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Review
    {
        /*
        review
        - reviewer name
        - content
        - album


         */

        public int Id { get; set; }
        public string Name { get; set; }
        public string ReviewContent { get; set; }

        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }



    }



}
