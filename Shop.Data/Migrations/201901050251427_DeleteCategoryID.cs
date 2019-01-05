namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posts", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "CategoryID", c => c.Int(nullable: false));
        }
    }
}
