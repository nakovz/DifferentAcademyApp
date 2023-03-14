namespace ConsoleGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateOfCodeFirstMigrationCreatedAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestFirstCodes", "DateOfCodeFirstMigrationCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TestFirstCodes", "DateOfCodeFirstMigrationCreated");
        }
    }
}
