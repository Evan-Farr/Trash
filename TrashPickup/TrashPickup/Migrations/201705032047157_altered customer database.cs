namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredcustomerdatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "userId_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Employees", "userId_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "userId_Id");
            CreateIndex("dbo.Employees", "userId_Id");
            AddForeignKey("dbo.Employees", "userId_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Customers", "userId_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "userId_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "userId_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "userId_Id" });
            DropIndex("dbo.Customers", new[] { "userId_Id" });
            DropColumn("dbo.Employees", "userId_Id");
            DropColumn("dbo.Customers", "userId_Id");
        }
    }
}
