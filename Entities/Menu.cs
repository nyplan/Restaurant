using RestaurantAPI.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        [StringLength(50)]
        public required string ItemName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [StringLength(maximumLength:500)]
        public string? Description { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; }
        public ICollection<OrderOneItem>? OrderOneItems { get; set; }
        public ICollection<BasketItems>? BasketItems { get; set; }
        public ICollection<DailySales>? DailySales { get; set; }
    }
}
