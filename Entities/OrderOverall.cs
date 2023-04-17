namespace RestaurantAPI.Model
{
    public class OrderOverall
    {
        public int Id { get; set; }
        public int TotalAmount { get; set; }
        public int CustomersId { get; set; }
        public Customers? Customers { get; set; }
    }
}
