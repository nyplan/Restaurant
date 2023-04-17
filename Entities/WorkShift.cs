using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class WorkShift
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string ShiftType { get; set; }
        [StringLength(15)]
        public required string StartTime { get; set; }
        [StringLength(15)]
        public required string EndTime { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
