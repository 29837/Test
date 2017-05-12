namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenderIdOfMoviesModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            AddColumn("dbo.Movies", "Gender_Id", c => c.Int());
            AlterColumn("dbo.Movies", "GenderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Gender_Id");
            AddForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Gender_Id" });
            AlterColumn("dbo.Movies", "GenderId", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Gender_Id");
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
