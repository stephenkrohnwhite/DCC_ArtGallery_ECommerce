namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedimaglefilepathpropertytoproductmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "FileImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "FileImagePath");
        }
    }
}
