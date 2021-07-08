namespace Universal_Chat_Plugin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatPlugin2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Organizations", "Username", c => c.String(nullable: false));
            AddColumn("dbo.Organizations", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Organizations", "Password");
            DropColumn("dbo.Organizations", "Username");
        }
    }
}
