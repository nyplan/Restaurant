using RestaurantAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class PaymentType
    {
        public int Id { get; set; }
        [StringLength(25)]
        public required string Name { get; set; }
        public ICollection<Payments>? Payments { get; set; }
        public ICollection<Basket>? Baskets { get; set; }
    }
}
