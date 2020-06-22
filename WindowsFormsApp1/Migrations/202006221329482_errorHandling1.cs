namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorHandling1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Users", new[] { "RoomId" });
            DropPrimaryKey("dbo.Rooms");
            AlterColumn("dbo.Rooms", "RoomId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Rooms", "RoomId");
            CreateIndex("dbo.Rooms", "RoomId");
            AddForeignKey("dbo.Rooms", "RoomId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomId", "dbo.Users");
            DropIndex("dbo.Rooms", new[] { "RoomId" });
            DropPrimaryKey("dbo.Rooms");
            AlterColumn("dbo.Rooms", "RoomId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Rooms", "RoomId");
            CreateIndex("dbo.Users", "RoomId");
            AddForeignKey("dbo.Users", "RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
        }
    }
}
