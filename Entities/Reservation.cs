namespace RestaurantAPI.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int? CustomersId { get; set; }
        public Customers? Customers { get; set; }
        public DateTime DateAndTime { get; set; }
        public int NumberOfGuests { get; set; }
        public int TableId { get; set; }
        public Table? Table { get; set; }
        public ICollection<OnSite>? OnSites { get; set; }
        public ICollection<ByCall>? ByCalls { get; set; }
    }
}
