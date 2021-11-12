using album_collection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        
        private AlbumsContext _db;
        public SongController(AlbumsContext db)
        {
            _db = db;
        }

        [HttpGet("{id}")]
        public ActionResult<Song> Get(int id)
        {
            return _db.Songs.Find(id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Song>> Get()
        {
            return _db.Songs.ToList();
        }


        [HttpPost]
        public ActionResult<Song> Post([FromBody] Song song)
        {
            _db.Songs.Add(song);
            _db.SaveChanges();
            return song;
        }

        [HttpPut("{id}")]
        public ActionResult<Song> Edit(int id, [FromBody] Song song)
        {
            _db.Songs.Update(song);
            _db.SaveChanges();
            return song;
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Song>> Delete(int id)
        {
            var song = _db.Songs.Find(id);
            _db.Songs.Remove(song);
            _db.SaveChanges();
            return _db.Songs.ToList();
        }
    }
}

