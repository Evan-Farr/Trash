namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredcustomerandemployeemodels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MiddleInitial", c => c.String(maxLength: 1));
            AddColumn("dbo.Customers", "NextScheduledPickUp", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "MiddleInitial", c => c.String(maxLength: 1));
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "ZipCode", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Customers", "Phone", c => c.String(maxLength: 10));
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "ZipCode", c => c.String(nullable: false, maxLength: 5));
            AlterColumn("dbo.Employees", "Phone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "StreetAddress", c => c.String());
            DropColumn("dbo.Employees", "MiddleInitial");
            DropColumn("dbo.Customers", "NextScheduledPickUp");
            DropColumn("dbo.Customers", "MiddleInitial");
        }
    }
}
