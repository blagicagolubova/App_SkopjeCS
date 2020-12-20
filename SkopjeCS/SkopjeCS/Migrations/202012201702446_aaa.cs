namespace SkopjeCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Comments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        comment = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.comment);
            
        }
    }
}
