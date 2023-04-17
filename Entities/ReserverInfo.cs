using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class ReserverInfo
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string CustomerName { get; set; }
        [StringLength(50)]
        public required string CustomerSurname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int CustomerPhone { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public ICollection<ByCall>? ByCalls { get; set; }
    }
}
