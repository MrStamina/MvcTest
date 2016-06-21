namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MemberShipTypeID" });
            CreateIndex("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            CreateIndex("dbo.Customers", "MemberShipTypeID");
        }
    }
}
