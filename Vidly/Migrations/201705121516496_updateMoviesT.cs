namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviesT : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            DropColumn("dbo.Movies", "GenderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "GenderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
