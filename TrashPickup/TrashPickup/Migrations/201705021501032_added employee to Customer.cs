namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedemployeetoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "TrashMan_Id", c => c.Int());
            CreateIndex("dbo.Customers", "TrashMan_Id");
            AddForeignKey("dbo.Customers", "TrashMan_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "TrashMan_Id", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "TrashMan_Id" });
            DropColumn("dbo.Customers", "TrashMan_Id");
        }
    }
}
