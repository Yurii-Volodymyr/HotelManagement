namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _as : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        Price = c.Double(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.FoodId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Gender = c.String(),
                        Passport = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        RoomNumber = c.String(),
                        TotalCosting = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                        Description = c.String(),
                        RoomImage = c.String(),
                        PricePerWeek = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRolesId = c.Int(nullable: false, identity: true),
                        UserRole = c.String(),
                    })
                .PrimaryKey(t => t.UserRolesId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        UserRole = c.Int(nullable: false),
                        Roles_UserRolesId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserRoles", t => t.Roles_UserRolesId)
                .Index(t => t.Roles_UserRolesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Roles_UserRolesId", "dbo.UserRoles");
            DropIndex("dbo.Users", new[] { "Roles_UserRolesId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Rooms");
            DropTable("dbo.Orders");
            DropTable("dbo.Foods");
        }
    }
}
