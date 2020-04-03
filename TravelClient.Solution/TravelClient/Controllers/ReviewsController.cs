using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            var allReviews = Review.GetReviews();
            return View(allReviews);
        }

        [HttpPost]
        public IActionResult Index(Review review)
        {
            Review.AddReview(review);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var singleReview = Review.GetDetails(id);
            return View(singleReview);
        }

        public IActionResult Edit(int id)
        {
            var review = Review.GetDetails(id);
            return View(review);
        }

        [HttpPost]
        public IActionResult Details(int id, Review review)
        {
            review.ReviewId = id;
            Review.Update(review);
            return RedirectToAction("Details", id);
        }

    }
}
