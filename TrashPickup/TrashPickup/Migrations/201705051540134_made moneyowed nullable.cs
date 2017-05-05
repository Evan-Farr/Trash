namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mademoneyowednullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MoneyOwed", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MoneyOwed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
