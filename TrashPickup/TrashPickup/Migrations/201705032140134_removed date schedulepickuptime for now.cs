namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeddateschedulepickuptimefornow : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "NextScheduledPickup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "NextScheduledPickup", c => c.DateTime(nullable: false));
        }
    }
}
