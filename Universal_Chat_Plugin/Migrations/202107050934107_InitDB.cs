namespace Universal_Chat_Plugin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Password = c.String(),
                        Username = c.String(),
                        Gender = c.String(),
                        Addresss = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                        Marital_status = c.String(),
                        Blood_group = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Payment_type = c.String(),
                        Payment_status = c.String(),
                        Card_no = c.Int(nullable: false),
                        CVC = c.Int(nullable: false),
                        Payment_date = c.DateTime(nullable: false),
                        Total_amount = c.Int(nullable: false),
                        Paid_amount = c.Int(nullable: false),
                        Due_amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
            DropTable("dbo.Admins");
        }
    }
}
