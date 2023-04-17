namespace RestaurantAPI.Model
{
    public class OnSite
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public Reservation? Reservation { get; set; }
    }
}
