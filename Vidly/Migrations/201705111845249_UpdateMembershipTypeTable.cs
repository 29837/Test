namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Quaterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");
        }

        public override void Down()
        {
            Sql("UPDATE MembershipTypes SET Name = null WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = null WHERE Id = 4");
        }
    }
}
