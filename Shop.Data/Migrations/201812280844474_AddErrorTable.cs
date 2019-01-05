namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropPrimaryKey("dbo.PostCategories");
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.PostCategories", "ID", c => c.Int(nullable: false));
            AddColumn("dbo.PostCategories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "CategoryID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PostCategories", "ID");
            AddForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories");
            DropPrimaryKey("dbo.PostCategories");
            DropColumn("dbo.Posts", "CategoryID");
            DropColumn("dbo.PostCategories", "Status");
            DropColumn("dbo.PostCategories", "ID");
            DropTable("dbo.Errors");
            AddPrimaryKey("dbo.PostCategories", "PostCategoryID");
            AddForeignKey("dbo.Posts", "PostCategoryID", "dbo.PostCategories", "PostCategoryID", cascadeDelete: true);
        }
    }
}
