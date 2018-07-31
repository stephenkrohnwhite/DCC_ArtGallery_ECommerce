namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedspellingerrorincreaterolls : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserRole", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserRol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserRol", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserRole");
        }
    }
}
