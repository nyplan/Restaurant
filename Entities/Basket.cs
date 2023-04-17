using RestaurantAPI.Model;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public Customers? Customers { get; set; }
        public int? DiscountId { get; set; }
        public Discount? Discount { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public int? CreditCartId { get; set; }
        public CreditCart? CreditCart { get; set; }
        public int Total { get; set; }
        [StringLength(100)]
        public required string Address { get; set; }
        public ICollection<BasketItems>? BasketItems { get; set; }
        public ICollection<TrackingDelivery>? TrackingDeliveries { get; set; }
    }
}
