namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Artist_ArtistID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        AlbumID = c.Int(nullable: false),
                        Contents = c.String(),
                        ReviewerEmail = c.String(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Albums", t => t.AlbumID, cascadeDelete: true)
                .Index(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Reviews", new[] { "AlbumID" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
