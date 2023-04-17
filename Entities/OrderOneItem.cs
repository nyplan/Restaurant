namespace RestaurantAPI.Model
{
    public class OrderOneItem
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public int Count { get; set; }
        public int Amount { get; set; }
        public int CustomersId { get; set; }
        public Customers? Customers { get; set; }
        public int TableId { get; set; }
        public Table? Table { get; set; }
    }
}
