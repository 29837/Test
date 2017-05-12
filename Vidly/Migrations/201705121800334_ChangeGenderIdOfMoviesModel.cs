namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenderIdOfMoviesModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            AlterColumn("dbo.Movies", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            AlterColumn("dbo.Movies", "GenderId", c => c.Int());
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id");
        }
    }
}
