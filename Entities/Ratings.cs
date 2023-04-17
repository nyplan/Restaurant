using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Ratings
    {
        public int Id { get; set; }
        [StringLength(15)]
        public required string Stars { get; set; }
        public ICollection<Feedback>? Feedbacks { get; set; }
    }
}
