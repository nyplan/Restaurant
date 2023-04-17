namespace RestaurantAPI.Model
{
    public class Payments
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int? CustomersId { get; set; }
        public Customers? Customers { get; set; }
        public int? TableId { get; set; }
        public Table? Table { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType? PaymentType { get; set; }
        public int? CreditCartId { get; set; }
        public CreditCart? CreditCart { get; set; }
    }
}
