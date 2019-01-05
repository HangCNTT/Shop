namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuditable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Products", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 250));
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyword");
            DropColumn("dbo.Posts", "UpdateBy");
            DropColumn("dbo.Posts", "UpdatedDate");
            DropColumn("dbo.Posts", "CreateBy");
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "MetaKeyword");
            DropColumn("dbo.PostCategories", "UpdateBy");
            DropColumn("dbo.PostCategories", "UpdatedDate");
            DropColumn("dbo.PostCategories", "CreateBy");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "UpdateBy");
            DropColumn("dbo.Pages", "UpdatedDate");
            DropColumn("dbo.Pages", "CreateBy");
            DropColumn("dbo.Pages", "CreatedDate");
            DropColumn("dbo.ProductCategories", "Status");
            DropColumn("dbo.ProductCategories", "MetaDescription");
            DropColumn("dbo.ProductCategories", "MetaKeyword");
            DropColumn("dbo.ProductCategories", "UpdateBy");
            DropColumn("dbo.ProductCategories", "UpdatedDate");
            DropColumn("dbo.ProductCategories", "CreateBy");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "Status");
            DropColumn("dbo.Products", "MetaDescription");
            DropColumn("dbo.Products", "MetaKeyword");
            DropColumn("dbo.Products", "UpdateBy");
            DropColumn("dbo.Products", "UpdatedDate");
            DropColumn("dbo.Products", "CreateBy");
            DropColumn("dbo.Products", "CreatedDate");
        }
    }
}
