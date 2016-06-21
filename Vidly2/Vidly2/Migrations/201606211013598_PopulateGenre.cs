namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id, Libelle) Values (1,'Comedie')");
            Sql("INSERT INTO dbo.Genres (Id, Libelle) Values (2,'Horreur')");
            Sql("INSERT INTO dbo.Genres (Id, Libelle) Values (3,'Policier')");
            Sql("INSERT INTO dbo.Genres (Id, Libelle) Values (4,'Romantique')");
            Sql("INSERT INTO dbo.Genres (Id, Libelle) Values (5,'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
