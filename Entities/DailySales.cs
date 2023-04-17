using RestaurantAPI.Model;

namespace RestaurantAPI.Entities
{
    public class DailySales
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu? Menu{ get; set; }
        public int ItemsHad { get; set; }
        public int ItemsLeft { get; set; }
        public int Sold { get; set; }
        public int TotalAmount { get; set; }
    }
}
