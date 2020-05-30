namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "RoomType");
        }
    }
}
