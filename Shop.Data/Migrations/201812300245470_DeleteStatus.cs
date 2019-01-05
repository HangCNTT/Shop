namespace Shop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Status", c => c.Boolean());
        }
    }
}
