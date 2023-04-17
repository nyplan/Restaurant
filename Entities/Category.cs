using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
