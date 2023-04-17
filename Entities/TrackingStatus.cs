using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class TrackingStatus
    {
        public int Id { get; set; }
        [StringLength(100)]
        public required string StatusName { get; set; }
        public ICollection<TrackingDelivery>? TrackingDeliveries { get; set; }
    }
}
