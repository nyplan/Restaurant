using RestaurantAPI.Model;

namespace RestaurantAPI.Entities
{
    public class BasketItems
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public int Count { get; set; }
        public int BasketId { get; set; }
        public Basket? Basket { get; set; }
    }
}
