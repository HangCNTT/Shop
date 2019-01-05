namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateError : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Errors", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Errors", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Errors", "CreateDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Errors", "CreatedDate");
        }
    }
}
