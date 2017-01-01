namespace UpComingGibs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popilatateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES(1, 'Jazz')");
            Sql("INSERT INTO Genres VALUES(2, 'Blues')");
            Sql("INSERT INTO Genres VALUES(3, 'Rock')");
            Sql("INSERT INTO Genres VALUES(4, 'Country')");
        }
        
        public override void Down()
        {
        }
    }
}
