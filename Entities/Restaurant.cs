using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace RestaurantAPI.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        [StringLength(100)]
        public required string Name { get; set; }
        [StringLength(200)]
        public required string Address { get; set; }
        [Phone]
        public int Phone { get; set; }
        [EmailAddress]
        [StringLength(200)]
        public string? Email { get; set; }
        [StringLength(200)]
        public string? Website { get; set; }
        public DateTime Opens { get; set; }
        public DateTime Closes { get; set; }
        public ICollection<Customers>? Customers { get; set; }
        public ICollection<RestaurantEmployee>? RestaurantEmployees { get; set; }
        public ICollection<Table>? Tables { get; set; }
        public ICollection<ReserverInfo>? ReserverInfos { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Discount>? Discounts { get; set; }
    }
}
