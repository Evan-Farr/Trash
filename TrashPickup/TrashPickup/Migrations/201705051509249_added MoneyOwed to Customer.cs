namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedMoneyOwedtoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MoneyOwed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MoneyOwed");
        }
    }
}
