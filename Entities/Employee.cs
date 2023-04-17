using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(50)]
        public required string Firstname { get; set; }
        [StringLength(50)]
        public required string Lastname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(200)]
        public int Email { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        public int Salary { get; set; }
        public int WorkShiftId { get; set; }
        public WorkShift? WorkShift { get; set; }
        public ICollection<RestaurantEmployee>? RestaurantEmployees { get; set; }
    }
}
