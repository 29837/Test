namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenderIdOfMoviesModel3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Gender_Id" });
            DropColumn("dbo.Movies", "GenderId");
            RenameColumn(table: "dbo.Movies", name: "Gender_Id", newName: "GenderId");
            AlterColumn("dbo.Movies", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            AlterColumn("dbo.Movies", "GenderId", c => c.Int());
            AlterColumn("dbo.Movies", "GenderId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "GenderId", newName: "Gender_Id");
            AddColumn("dbo.Movies", "GenderId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Gender_Id");
            AddForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres", "Id");
        }
    }
}
