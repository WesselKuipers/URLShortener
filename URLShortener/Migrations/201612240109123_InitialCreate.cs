namespace URLShortener.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UploadedUrls",
                c => new
                    {
                        ShortenedUrl = c.String(nullable: false, maxLength: 128),
                        Url = c.String(),
                        Clicks = c.Int(nullable: false),
                        UploadDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ShortenedUrl);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UploadedUrls");
        }
    }
}
