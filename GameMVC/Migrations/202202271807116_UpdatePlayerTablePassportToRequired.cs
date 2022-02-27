namespace GameMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePlayerTablePassportToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Passport", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Passport", c => c.String(maxLength: 15));
        }
    }
}
