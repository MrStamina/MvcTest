namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into dbo.Movies (Name,ReleaseDate,DateAdded,Stock,GenreId) VALUES ('Rambo','2016-30-06', 2015-01-01,6, 5)");
            Sql("INSERT into dbo.Movies (Name,ReleaseDate,DateAdded,Stock,GenreId) VALUES ('Rambo2','2016-5-07', 2015-01-01,8, 5)");
            Sql("INSERT into dbo.Movies (Name,ReleaseDate,DateAdded,Stock,GenreId) VALUES ('Rambo3','2016-4-07', 2015-01-01,11, 5)");
            Sql("INSERT into dbo.Movies (Name,ReleaseDate,DateAdded,Stock,GenreId) VALUES ('Titanic','2016-30-06', 2015-01-01,2, 4)");
           
        }
        
        public override void Down()
        {
        }
    }
}
