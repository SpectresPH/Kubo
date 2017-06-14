namespace QBO_Events_Management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Status");
        }
    }
}
