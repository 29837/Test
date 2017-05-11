namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "Gender_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Gender_Id");
            AddForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Gender_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Gender_Id" });
            DropColumn("dbo.Movies", "Gender_Id");
            DropTable("dbo.Genres");
        }
    }
}
