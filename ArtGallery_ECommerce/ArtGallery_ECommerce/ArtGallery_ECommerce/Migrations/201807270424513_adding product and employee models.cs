namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingproductandemployeemodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        UserID = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        TrackingId = c.String(),
                        OrderTime = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Artist = c.String(),
                        Price = c.Double(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        Description = c.String(),
                        ProductSizeId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductSizes", t => t.ProductSizeId, cascadeDelete: true)
                .Index(t => t.ProductSizeId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductSizes",
                c => new
                    {
                        ProductSizeId = c.Int(nullable: false, identity: true),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.ProductSizeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductSizeId", "dbo.ProductSizes");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Orders", "StatusId", "dbo.Status");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "ProductSizeId" });
            DropIndex("dbo.Orders", new[] { "StatusId" });
            DropTable("dbo.ProductSizes");
            DropTable("dbo.Products");
            DropTable("dbo.Status");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.Categories");
        }
    }
}
