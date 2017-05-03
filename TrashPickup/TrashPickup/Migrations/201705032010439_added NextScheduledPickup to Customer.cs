namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNextScheduledPickuptoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NextScheduledPickup", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NextScheduledPickup");
        }
    }
}
