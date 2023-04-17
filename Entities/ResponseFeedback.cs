using RestaurantAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class ResponseFeedback
    {
        public int Id { get; set; }
        public int FeedbackId { get; set; }
        public Feedback? Feedback { get; set; }
        [StringLength(300)]
        public string? Comments { get; set; }
    }
}
