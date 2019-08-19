namespace ClothBazar.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurationalbe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configs",
                c => new
                    {
                        key = c.String(nullable: false, maxLength: 128),
                        value = c.String(),
                    })
                .PrimaryKey(t => t.key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Configs");
        }
    }
}
