using album_collection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace album_collection.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private AlbumsContext _db;
        public ArtistController(AlbumsContext db)
        {
            _db = db;
        }


        // GET: api/<ArtistController>
        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get()
        {
            return _db.Artists.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Artist> Get(int id)
        {
            return _db.Artists.Find(id);
        }

        // POST api/<ArtistController>
        [HttpPost]
        public ActionResult<Artist> Post([FromBody] Artist artist)
        {
            _db.Artists.Add(artist);
            _db.SaveChanges();
            return artist;
        }

        // PUT api/<ArtistController>/5
        [HttpPut("{id}")]
        public ActionResult<Artist> Put(int id, [FromBody] Artist artist)
        {
            _db.Artists.Update(artist);
            _db.SaveChanges();
            return artist;
        }

        // DELETE api/<ArtistController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Artist>> Delete(int id)
        {
            _db.Artists.Remove(_db.Artists.Find(id));
            _db.SaveChanges();
            return _db.Artists.ToList();
        }
    }
}
