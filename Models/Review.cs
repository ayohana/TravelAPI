namespace TravelAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Destination { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}