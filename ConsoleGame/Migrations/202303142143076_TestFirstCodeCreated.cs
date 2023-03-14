namespace ConsoleGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestFirstCodeCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestFirstCodes",
                c => new
                    {
                        TestFirstCodeId = c.Int(nullable: false, identity: true),
                        TestFirstCodeName = c.String(),
                    })
                .PrimaryKey(t => t.TestFirstCodeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestFirstCodes");
        }
    }
}
