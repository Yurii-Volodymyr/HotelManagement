using System;
using System.Data.Entity;
using Hotel.Domain.Model;
using Hotel.Domain.Model.Map;
//using Hotel.Domain.Model.Map;

namespace Hotel.Domain
{ 

    public class HotelWinFormsDbContext : DbContext, IDisposable
    {

        public HotelWinFormsDbContext() : base("HotelDbContext")
        {

        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<ServFoodOrder> ServiceFood { get; set; }
        public virtual DbSet<ServRoomOrder> ServiceRoom { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new ServFoodOrderMap());

        }
    }

    
}
