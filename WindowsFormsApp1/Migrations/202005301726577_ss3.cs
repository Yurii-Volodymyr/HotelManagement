namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "RoomType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "RoomType", c => c.Int(nullable: false));
        }
    }
}
