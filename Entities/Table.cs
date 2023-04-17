namespace RestaurantAPI.Model
{
    public class Table
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<Payments>? Payments { get; set; }
        public ICollection<OrderOneItem>? OrderOneItems { get; set; }
    }
}
