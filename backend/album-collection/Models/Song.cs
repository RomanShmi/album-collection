﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Song
    {
        /*
        song
           - id
           - title
           - album 
         */

         public int Id { get; set; }

        public string Title { get; set; }


        public int AlbumId { get; set; }


        public virtual Album Album { get; set; }

    }
}
