namespace TrashPickup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TruckId = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        StreetAddress = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
