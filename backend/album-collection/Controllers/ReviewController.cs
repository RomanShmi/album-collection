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
    public class ReviewController : ControllerBase
    {
        private AlbumsContext _db;
        public ReviewController(AlbumsContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get()
        {
            return _db.Reviews.ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.Find(id);
        }

        // POST api/<ArtistController>
        [HttpPost]
        public ActionResult<Review> Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
            return review;
        }

        // PUT api/<ArtistController>/5
        [HttpPut("{id}")]
        public ActionResult<Review> Put(int id, [FromBody] Review review)
        {
            _db.Reviews.Update(review);
            _db.SaveChanges();
            return review;
        }

        // DELETE api/<ArtistController>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Review>> Delete(int id)
        {
            _db.Reviews.Remove(_db.Reviews.Find(id));
            _db.SaveChanges();
            return _db.Reviews.ToList();
        }
    }
}
