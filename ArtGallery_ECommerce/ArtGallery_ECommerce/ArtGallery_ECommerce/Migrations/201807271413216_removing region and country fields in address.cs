namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removingregionandcountryfieldsinaddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "State", c => c.String(nullable: false));
            DropColumn("dbo.Addresses", "SelectedCountryIso3");
            DropColumn("dbo.Addresses", "SelectedRegionCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "SelectedRegionCode", c => c.String(nullable: false));
            AddColumn("dbo.Addresses", "SelectedCountryIso3", c => c.String(nullable: false));
            DropColumn("dbo.Addresses", "State");
        }
    }
}
