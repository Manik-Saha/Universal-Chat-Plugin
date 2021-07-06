namespace Universal_Chat_Plugin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChatPlugin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Addresss = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                        Marital_status = c.String(nullable: false),
                        Blood_group = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Payment_type = c.String(),
                        Payment_status = c.String(),
                        Card_no = c.Int(nullable: false),
                        CVC = c.Int(nullable: false),
                        Payment_date = c.DateTime(nullable: false),
                        Total_amount = c.Int(nullable: false),
                        Paid_amount = c.Int(nullable: false),
                        Due_amount = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.OrganizationId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_name = c.String(nullable: false),
                        Last_name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Payments", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Payments", new[] { "User_Id" });
            DropIndex("dbo.Payments", new[] { "OrganizationId" });
            DropTable("dbo.Users");
            DropTable("dbo.Payments");
            DropTable("dbo.Organizations");
            DropTable("dbo.Admins");
        }
    }
}
