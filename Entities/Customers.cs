using RestaurantAPI.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Customers
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string Firstname { get; set; }
        [StringLength(50)]
        public string? Lastname { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(200)]
        public string? Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [DataType(DataType.Password)]
        public int Password { get; set; }
        [StringLength(100)]
        public string? Address { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Payments>? Payments { get; set; }
        public ICollection<OrderOverall>? OrderOveralls { get; set; }
        public ICollection<OrderOneItem>? OrderOneItems { get; set; }
        public ICollection<Feedback>? Feedbacks { get; set; }
        public ICollection<Basket>? Baskets { get; set; }
    }
}
