using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities;
using RestaurantAPI.Model;

namespace RestaurantAPI.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantEmployee>().HasKey(e => new { e.EmployeeId, e.RestaurantId });

            modelBuilder.Entity<Reservation>()
             .HasOne(r => r.Table)
             .WithMany()
             .HasForeignKey(r => r.TableId)
             .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RestaurantEmployee> RestaurantEmployees { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<ReserverInfo> ReserverInfos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<OnSite> OnSites { get; set; }
        public DbSet<ByCall> ByCalls { get; set; }
        public DbSet<CreditCart> CreditCarts { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<OrderOverall> OrderOveralls { get; set; }
        public DbSet<OrderOneItem> OrderOneItems { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ResponseFeedback> ResponseFeedbacks { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<TrackingStatus> TrackingStatuses { get; set; }
        public DbSet<TrackingDelivery> TrackingDeliveries { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<DailySales> DailySales { get; set; }
    }
}
