using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class Courier
    {
        public int Id { get; set; }
        [StringLength(30)]
        public required string Firstname { get; set; }
        [StringLength(40)]
        public required string Lastname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        public ICollection<TrackingDelivery>? TrackingDeliveries { get; set; }
    }
}
