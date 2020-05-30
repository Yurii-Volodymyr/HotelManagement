namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adws : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "IsAvailable", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "IsAvailable", c => c.Boolean(nullable: false));
        }
    }
}
