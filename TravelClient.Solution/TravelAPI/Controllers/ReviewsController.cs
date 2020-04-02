using TravelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/reviews")]
    [ApiController]
    public class ReviewsV1Controller : ControllerBase
    {
        private TravelAPIContext _db;
        public ReviewsV1Controller(TravelAPIContext db)
        {
            _db = db;
        }

        // GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "This is", "Version 1" };
        }

        // GET api/reviews
        // [HttpGet]
        // public ActionResult<IEnumerable<Review>> Get(string destination, int rating)
        // {
        //     var query = _db.Reviews.AsQueryable();
        //     if (destination != null)
        //     {
        //         query = query.Where(entry => entry.Destination == destination);
        //     }
        //     if (rating >= 0) // this condition does not work since API versioning was applied
        //     {
        //         query = query.Where(entry => entry.Rating == rating);
        //     }
        //     return query.ToList();
        // }

        // POST api/reviews
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        // GET api/reviews/5
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
        }

        // PUT api/reviews/5/user_name
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

        // DELETE api/reviews/5/user_name
        [HttpDelete("{id}/{user_name}")]
        public void Delete(int id, string user_name)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(review => review.ReviewId == id && review.user_name == user_name);
            if (reviewToDelete != null)
            {
                _db.Reviews.Remove(reviewToDelete);
                _db.SaveChanges();
            }
        }

         // GET api/reviews/random
        [HttpGet("random")]
        public ActionResult<Review> GetRandom()
        {
            var completeList = _db.Reviews.ToList();
            List<int> allIds = new List<int> ();
            foreach (Review review in completeList)
            {
                allIds.Add(review.ReviewId);
            }
            Random random = new Random();
            var randomId = allIds[random.Next(0, allIds.Count)];
            Console.WriteLine(">>>>>>>>>>>>>>>RANDOM REVIEW="+randomId);
            var randomReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == randomId);
            return randomReview;
        }
    }

    [ApiVersion("2.0")]
    [Route("api/{v:apiVersion}/reviews")]
    [ApiController]
    public class ReviewsV2Controller : ControllerBase
    {
        private TravelAPIContext _db;
        public ReviewsV2Controller(TravelAPIContext db)
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
            if (rating > 0)
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

        // GET api/reviews/5
        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(review => review.ReviewId == id);
        }

        // PUT api/reviews/5/user_name
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

        // DELETE api/reviews/5/user_name
        [HttpDelete("{id}/{user_name}")]
        public void Delete(int id, string user_name)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(review => review.ReviewId == id && review.user_name == user_name);
            if (reviewToDelete != null)
            {
                _db.Reviews.Remove(reviewToDelete);
                _db.SaveChanges();
            }
        }

         // GET api/reviews/random
        [HttpGet("random")]
        public ActionResult<Review> GetRandom()
        {
            var completeList = _db.Reviews.ToList();
            List<int> allIds = new List<int> ();
            foreach (Review review in completeList)
            {
                allIds.Add(review.ReviewId);
            }
            Random random = new Random();
            var randomId = allIds[random.Next(0, allIds.Count)];
            var randomReview = _db.Reviews.FirstOrDefault(review => review.ReviewId == randomId);
            return randomReview;
        }
    }
}
