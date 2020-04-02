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

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());
      
      return reviewList;
    }

    public static Review GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetSingleReview(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Review review = JsonConvert.DeserializeObject<Review>(jsonResponse.ToString());

      return review;
    }
  }
}