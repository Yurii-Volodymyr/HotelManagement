namespace WindowsFormsApp1.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using WindowsFormsApp1.Model;

    public class HotelWinFormsDbContext : DbContext, IDisposable
    {
        public HotelWinFormsDbContext() : base("HotelDbContext")
        {

        }


        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }

    }
    //public class HotelDBInitializer : DropCreateDatabaseAlways<HotelWinFormsDbContext>
    //{

    //    protected override void Seed(HotelWinFormsDbContext context)
    //    {
    //        IList<Room> defaultRooms = new List<Room>();

    //        defaultRooms.Add(new Room() { RoomImage = "Standard 1", Description = "First Standard", RoomNumber = "1 A", PricePerWeek = 300 });
    //        defaultRooms.Add(new Room() { RoomImage = "Standard 2", Description = "Second Standard", RoomNumber = "1B", PricePerWeek = 500 });
    //        defaultRooms.Add(new Room() { RoomImage = "Standard 3", Description = "Third Standard", RoomNumber = "2", PricePerWeek = 600 });
    //        context.Rooms.AddRange(defaultRooms);

    //        IList<UserRoles> roles = new List<UserRoles>();

    //        roles.Add(new UserRoles() { UserRole = "Admin" });
    //        roles.Add(new UserRoles() { UserRole = "Employee" });
    //        roles.Add(new UserRoles() { UserRole = "Client" });
    //        roles.Add(new UserRoles() { UserRole = "Guest" });
    //        context.UserRoles.AddRange(roles);

    //        base.Seed(context);
    //    }



    //}
}