namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePostCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropPrimaryKey("dbo.PostCategories");
            AddPrimaryKey("dbo.PostCategories", "PostCategoryID");
            AddForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories", "PostCategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropPrimaryKey("dbo.PostCategories");
            AddPrimaryKey("dbo.PostCategories", "ID");
            AddForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories", "ID", cascadeDelete: true);
        }
    }
}
