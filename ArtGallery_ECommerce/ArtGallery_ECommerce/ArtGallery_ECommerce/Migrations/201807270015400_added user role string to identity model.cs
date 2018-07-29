namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeduserrolestringtoidentitymodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserRol", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserRol");
        }
    }
}
