namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rounddecimalofmoneyowedto2decimalplaces : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "MoneyOwed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "MoneyOwed", c => c.String());
        }
    }
}
