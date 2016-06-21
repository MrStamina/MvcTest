namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Movies SET ReleaseDate = '20160630',DateAdded = '20160621' WHERE Id = 1 ");
            Sql("UPDATE dbo.Movies SET ReleaseDate = '20160702',DateAdded = '20160621' WHERE Id = 2 ");
            Sql("UPDATE dbo.Movies SET ReleaseDate = '20160701',DateAdded = '20160621' WHERE Id = 3 ");
            Sql("UPDATE dbo.Movies SET ReleaseDate = '20160630',DateAdded = '20160621' WHERE Id = 4 ");
            Sql("INSERT INTO dbo.Movies (Name,ReleaseDate,Stock,GenreId) VALUES('Mad Max','2016-07-04',5,5)");
        }
        
        public override void Down()
        {
        }
    }
}
