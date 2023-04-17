using RestaurantAPI.Entities;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class CreditCart
    {
        public int Id { get; set; }
        [DataType(DataType.CreditCard)]
        [StringLength(25)]
        public required string CardNumber { get; set; }
        public int CIF { get; set; }
        [StringLength(100)]
        public required string HolderName { get; set; }
        public ICollection<Payments>? Payments { get; set; }
        public ICollection<Basket>? Baskets { get; set; }
    }
}
