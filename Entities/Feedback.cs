using RestaurantAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Feedback
    {
        public int Id { get; set; }
        public int? CustomersId { get; set; }
        public Customers? Customers { get; set; }
        public int RatingsId { get; set; }
        public Ratings? Ratings { get; set; }
        [StringLength(300)]
        public string? Comments { get; set; }
        public ICollection<ResponseFeedback>? ResponseFeedbacks { get; set; }
    }
}
