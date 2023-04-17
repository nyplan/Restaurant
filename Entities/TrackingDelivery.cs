namespace RestaurantAPI.Entities
{
    public class TrackingDelivery
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public Basket? Basket { get; set; }
        public int CourierId { get; set; }
        public Courier? Courier { get; set; }
        public int TrackingStatusId { get; set; }
        public TrackingStatus? TrackingStatus { get; set; }
        public ICollection<OrderHistory>? OrderHistories { get; set; }
    }
}
