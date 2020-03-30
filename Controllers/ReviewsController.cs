using TravelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private TravelAPIContext _db;
        public ReviewsController(TravelAPIContext db)
        {
            _db = db;
        }

        // GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string destination, int rating)
        {
            var query = _db.Reviews.AsQueryable();
            if (destination != null)
            {
                query = query.Where(entry => entry.Destination == destination);
            }
            if (rating >= 0)
            {
                query = query.Where(entry => entry.Rating == rating);
            }
            return query.ToList();
        }

        // POST api/reviews
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        // // GET api/reviews/5
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
        }

        // PUT api/reviews/5
        [HttpPut("{id}/{user_name}")]
        public void Put(int id, [FromBody] Review review, string user_name)
        {
            if (review.user_name.ToLower() == user_name.ToLower())
            {
                review.ReviewId = id;
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
            }
        }

        // DELETE api/reviews/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}
