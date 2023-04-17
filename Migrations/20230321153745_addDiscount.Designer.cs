﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAPI.DAL;

#nullable disable

namespace RestaurantAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20230321153745_addDiscount")]
    partial class addDiscount
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantAPI.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CouponName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.ResponseFeedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("FeedbackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackId");

                    b.ToTable("ResponseFeedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Model.ByCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CallTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("ReserverInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("ReserverInfoId");

                    b.ToTable("ByCalls");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RestaurantAPI.Model.CreditCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CIF")
                        .HasColumnType("int");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CreditCarts");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("WorkShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("WorkShiftId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comments")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("RatingsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("RatingsId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OnSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("OnSites");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OrderOneItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("MenuId");

                    b.HasIndex("TableId");

                    b.ToTable("OrderOneItems");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OrderOverall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.ToTable("OrderOveralls");
                });

            modelBuilder.Entity("RestaurantAPI.Model.PaymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Payments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CreditCartId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreditCartId");

                    b.HasIndex("CustomersId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("TableId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Ratings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Stars")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("RestaurantAPI.Model.ReserverInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerPhone")
                        .HasColumnType("int");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("ReserverInfos");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Closes")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Opens")
                        .HasColumnType("datetime2");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RestaurantAPI.Model.RestaurantEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantEmployees");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("RestaurantAPI.Model.WorkShift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ShiftType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("WorkShifts");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Discount", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("Discounts")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.ResponseFeedback", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Feedback", "Feedback")
                        .WithMany("ResponseFeedbacks")
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");
                });

            modelBuilder.Entity("RestaurantAPI.Model.ByCall", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Reservation", "Reservation")
                        .WithMany("ByCalls")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.ReserverInfo", "ReserverInfo")
                        .WithMany("ByCalls")
                        .HasForeignKey("ReserverInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("ReserverInfo");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Customers", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("Customers")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Employee", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.WorkShift", "WorkShift")
                        .WithMany("Employees")
                        .HasForeignKey("WorkShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("WorkShift");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Feedback", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Customers", "Customers")
                        .WithMany("Feedbacks")
                        .HasForeignKey("CustomersId");

                    b.HasOne("RestaurantAPI.Model.Ratings", "Ratings")
                        .WithMany("Feedbacks")
                        .HasForeignKey("RatingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Menu", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Category", "Category")
                        .WithMany("Menus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OnSite", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Reservation", "Reservation")
                        .WithMany("OnSites")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OrderOneItem", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Customers", "Customers")
                        .WithMany("OrderOneItems")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.Menu", "Menu")
                        .WithMany("OrderOneItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.Table", "Table")
                        .WithMany("OrderOneItems")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Menu");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantAPI.Model.OrderOverall", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Customers", "Customers")
                        .WithMany("OrderOveralls")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Payments", b =>
                {
                    b.HasOne("RestaurantAPI.Model.CreditCart", "CreditCart")
                        .WithMany("Payments")
                        .HasForeignKey("CreditCartId");

                    b.HasOne("RestaurantAPI.Model.Customers", "Customers")
                        .WithMany("Payments")
                        .HasForeignKey("CustomersId");

                    b.HasOne("RestaurantAPI.Model.PaymentType", "PaymentType")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.Table", "Table")
                        .WithMany("Payments")
                        .HasForeignKey("TableId");

                    b.Navigation("CreditCart");

                    b.Navigation("Customers");

                    b.Navigation("PaymentType");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Reservation", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Customers", "Customers")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomersId");

                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantAPI.Model.ReserverInfo", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("ReserverInfos")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Model.RestaurantEmployee", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Employee", "Employee")
                        .WithMany("RestaurantEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("RestaurantEmployees")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Table", b =>
                {
                    b.HasOne("RestaurantAPI.Model.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Category", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("RestaurantAPI.Model.CreditCart", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Customers", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("OrderOneItems");

                    b.Navigation("OrderOveralls");

                    b.Navigation("Payments");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Employee", b =>
                {
                    b.Navigation("RestaurantEmployees");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Feedback", b =>
                {
                    b.Navigation("ResponseFeedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Menu", b =>
                {
                    b.Navigation("OrderOneItems");
                });

            modelBuilder.Entity("RestaurantAPI.Model.PaymentType", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Ratings", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Reservation", b =>
                {
                    b.Navigation("ByCalls");

                    b.Navigation("OnSites");
                });

            modelBuilder.Entity("RestaurantAPI.Model.ReserverInfo", b =>
                {
                    b.Navigation("ByCalls");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Restaurant", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Discounts");

                    b.Navigation("Reservations");

                    b.Navigation("ReserverInfos");

                    b.Navigation("RestaurantEmployees");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("RestaurantAPI.Model.Table", b =>
                {
                    b.Navigation("OrderOneItems");

                    b.Navigation("Payments");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantAPI.Model.WorkShift", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
