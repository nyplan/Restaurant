using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Role
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
