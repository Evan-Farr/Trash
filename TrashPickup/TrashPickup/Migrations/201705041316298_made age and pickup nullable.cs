namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeageandpickupnullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Age", c => c.Int());
            AlterColumn("dbo.Customers", "NextScheduledPickUp", c => c.DateTime());
            AlterColumn("dbo.Employees", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "NextScheduledPickUp", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
        }
    }
}
