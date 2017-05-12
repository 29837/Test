namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteGenreTable1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
