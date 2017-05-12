namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenderId", c => c.Int());
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            DropColumn("dbo.Movies", "GenderId");
        }
    }
}
