namespace RestaurantAPI.Model
{
    public class ByCall
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
        public int ReserverInfoId { get; set; }
        public ReserverInfo? ReserverInfo { get; set; }
        public DateTime CallTime { get; set; } = DateTime.Now;
    }
}
