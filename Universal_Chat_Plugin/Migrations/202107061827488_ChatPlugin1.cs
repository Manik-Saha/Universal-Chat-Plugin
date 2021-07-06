namespace Universal_Chat_Plugin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatPlugin1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Organizations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Organizations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Organizations", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Organizations", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Organizations", "Website", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Organizations", "Website", c => c.String());
            AlterColumn("dbo.Organizations", "Phone", c => c.String());
            AlterColumn("dbo.Organizations", "Address", c => c.String());
            AlterColumn("dbo.Organizations", "Email", c => c.String());
            AlterColumn("dbo.Organizations", "Name", c => c.String());
        }
    }
}
