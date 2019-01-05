namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteIDPostCategory : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PostCategories", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostCategories", "ID", c => c.Int(nullable: false));
        }
    }
}
