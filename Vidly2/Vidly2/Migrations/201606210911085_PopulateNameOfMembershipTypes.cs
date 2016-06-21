namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Update dbo.MembershipTypes SET name= 'Pay as You GO' WHERE Id=1");
            Sql("Update dbo.MembershipTypes SET name= 'Monthly' WHERE Id=2");
            Sql("Update dbo.MembershipTypes SET name= 'Quarterly' WHERE Id=3");
            Sql("Update dbo.MembershipTypes SET name= 'Annual' WHERE Id=4");

        }
        
        public override void Down()
        {       
        }
    }
}
