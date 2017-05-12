namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeGenreFromMovieTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Gender_Id" });
            DropColumn("dbo.Movies", "Gender_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Gender_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Gender_Id");
            AddForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres", "Id");
        }
    }
}
