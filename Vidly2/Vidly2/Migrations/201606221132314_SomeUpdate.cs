namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 75));
            AlterColumn("dbo.Genres", "Libelle", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 75));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Libelle", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
