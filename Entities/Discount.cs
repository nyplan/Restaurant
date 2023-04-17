using RestaurantAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string CouponName { get; set; }
        [StringLength(10)]
        public required string CouponCode { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public ICollection<Basket>? Baskets { get; set; }
    }
}
