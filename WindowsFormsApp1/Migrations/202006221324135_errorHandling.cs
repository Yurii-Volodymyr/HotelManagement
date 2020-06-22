namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorHandling : DbMigration
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
                        OrderId = c.Int(nullable: false),
                        ClientName = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Gender = c.String(),
                        Passport = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        RoomNumber = c.String(),
                        TotalCosting = c.Double(nullable: false),
                        UserOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Users", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.UserRoleId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomType = c.String(),
                        RoomNumber = c.String(),
                        Description = c.String(),
                        RoomImage = c.String(),
                        PricePerWeek = c.Double(nullable: false),
                        IsAvailable = c.String(),
                        UserRoomId = c.Int(nullable: false),
                        FoodRoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Foods", t => t.FoodRoomId, cascadeDelete: true)
                .Index(t => t.FoodRoomId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        UserRoleName = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserRoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserRoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Users", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "FoodRoomId", "dbo.Foods");
            DropForeignKey("dbo.Orders", "OrderId", "dbo.Users");
            DropIndex("dbo.Rooms", new[] { "FoodRoomId" });
            DropIndex("dbo.Users", new[] { "RoomId" });
            DropIndex("dbo.Users", new[] { "UserRoleId" });
            DropIndex("dbo.Orders", new[] { "OrderId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Rooms");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.Foods");
        }
    }
}
