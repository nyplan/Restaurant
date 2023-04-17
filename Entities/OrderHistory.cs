namespace RestaurantAPI.Entities
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public int TrackingDeliveryId { get; set; }
        public TrackingDelivery? TrackingDelivery { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
