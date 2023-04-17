namespace RestaurantAPI.Model
{
    public class RestaurantEmployee
    {
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
