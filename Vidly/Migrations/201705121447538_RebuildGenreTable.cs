namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RebuildGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenderId", c => c.Byte(nullable: true));
            CreateIndex("dbo.Movies", "GenderId");
            AddForeignKey("dbo.Movies", "GenderId", "dbo.Genres", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenderId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenderId" });
            DropColumn("dbo.Movies", "GenderId");
            DropTable("dbo.Genres");
        }
    }
}
