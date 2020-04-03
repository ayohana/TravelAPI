using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Destination { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }
    public string user_name { get; set; }
    
    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      // Convert result of response into JArray
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      // Convert JArray into List<Review>, a .NET object
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());
      
      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetSingleReview(id);
      var result = apiCallTask.Result;

      // Convert result of response into JObject
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // Convert JObject to a Review object
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }

    public static void AddReview(Review newReview)
    {
      // Convert input from Review object to JSON string type
      string jsonReview = JsonConvert.SerializeObject(newReview);
      var apiCallTask = ApiHelper.Post(jsonReview);
    }

    public static void Update(Review reviewToEdit)
    {
      // Convert input from Review object to JSON string type
      string jsonReview = JsonConvert.SerializeObject(reviewToEdit);
      var apiCallTask = ApiHelper.Put(reviewToEdit.ReviewId, reviewToEdit.user_name, jsonReview);
    }

    public static void Remove(int id, string user_name)
    {
      var apiCallTask = ApiHelper.Delete(id, user_name);
    }
  }
}