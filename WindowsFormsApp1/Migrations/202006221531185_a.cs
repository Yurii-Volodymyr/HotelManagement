namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToRoomOrder",
                c => new
                    {
                        ToRoomOrderId = c.Int(nullable: false, identity: true),
                        Burger = c.String(),
                        Cake = c.String(),
                        Pizza = c.String(),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ToRoomOrderId);
            
            AddColumn("dbo.Rooms", "RoomOrderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rooms", "RoomOrderId");
            AddForeignKey("dbo.Rooms", "RoomOrderId", "dbo.ToRoomOrder", "ToRoomOrderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomOrderId", "dbo.ToRoomOrder");
            DropIndex("dbo.Rooms", new[] { "RoomOrderId" });
            DropColumn("dbo.Rooms", "RoomOrderId");
            DropTable("dbo.ToRoomOrder");
        }
    }
}
