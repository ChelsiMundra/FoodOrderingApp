using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.DomainModel.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        readonly CultureInfo ci = CultureInfo.InvariantCulture;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {

                    Id = 1,
                    Name = "Sheetal",
                    Email_Id = "sheetal301@gmail.com",
                    Address = "Ajmer",
                    Password = "1233",
                    Role = "User",
                    CreatedAt = DateTime.ParseExact("04/22/2021", "MM/dd/yyyy", ci)

                },
                 new User
                 {
                     Id = 2,
                     Name = "Jay",
                     Email_Id = "jay01@gmail.com",
                     Address = "Jaipur",
                     Password = "1245",
                     Role = "User",
                     CreatedAt = DateTime.ParseExact("04/26/2021", "MM/dd/yyyy", ci)

                 },
                  new User
                  {
                      Id = 3,
                      Name = "Mayank",
                      Email_Id = "mak01@gmail.com",
                      Address = "Udaipur",
                      Password = "1255",
                      Role = "Restaurant Owner",
                      CreatedAt = DateTime.ParseExact("04/28/2021", "MM/dd/yyyy", ci)

                  }

                );
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    Id = 1,
                    UserId = 1,
                    RestaurantId = 1,
                    Rating = 4,
                    Review_Content = "Good",
                    Likes = 1,
                    IsComment = false,
                    CreatedAt = DateTime.ParseExact("04/30/2021", "MM/dd/yyyy", ci),
                    IsDeleted = false,


                }
                );
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    RestaurantName = "Pizza Hut",
                    ContactNumber = "9872312455",
                    Location = "Ajmer",
                    OpenTime = DateTime.ParseExact("02/25/33", "hh/mm/ss", ci),
                    CloseTime = DateTime.ParseExact("09/22/33", "hh/mm/ss", ci),
                    CostForTwo = 540,
                    Rating = 3,
                    CreatedAt = DateTime.ParseExact("05/28/2021", "MM/dd/yyyy", ci),
                    CreatedBy = 3,
                    DeletedBy = 3,
                    IsDeleted = false,
                    DeletedAt = DateTime.ParseExact("07/28/2021", "MM/dd/yyyy", ci)

                }
                );
            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {
                    Id = 1,
                    Name = "Menu1",
                    RestaurantId = 1,
                    CreatedAt = DateTime.ParseExact("05/28/2021", "MM/dd/yyyy", ci),
                    IsDeleted = false


                }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Dessert",
                    MenuId = 1,
                    CreatedAt = DateTime.ParseExact("05/28/2021", "MM/dd/yyyy", ci),

                    IsDeleted = false

                }
                );
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    CategoryId = 1,
                    DishName = "Chocolate Ice Cream",
                    Price = 100,
                    Description = "Ice Cream",
                    CreatedAt = DateTime.ParseExact("05/28/2021", "MM/dd/yyyy", ci),

                    IsDeleted = false

                }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    UserId = 2,
                    RestaurantId = 1,
                    TotalAmount = 100,
                    CreatedAt = DateTime.ParseExact("05/28/2021", "MM/dd/yyyy", ci),
                    IsDeleted = false


                }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail
                {
                    Id = 1,
                    OrderId = 1,
                    DishId = 1,
                    Price = 100,
                    Quantity = 1,
                    Status = "Delivered"

                }
                );
            modelBuilder.Entity<Follow>().HasData(
                new Follow
                {
                    Id = 2,
                    FollowerId = 2,
                    FollowedById = 2

                }
                );
        }

        }
}
