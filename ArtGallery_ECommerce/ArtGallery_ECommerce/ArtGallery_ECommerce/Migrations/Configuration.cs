namespace ArtGallery_ECommerce.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ArtGallery_ECommerce.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtGallery_ECommerce.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ArtGallery_ECommerce.Models.ApplicationDbContext";
        }

        protected override void Seed(ArtGallery_ECommerce.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Categories.AddOrUpdate(
            //    p => p.Name,
            //    new Categories { Name = "Abstract" },
            //    new Categories { Name = "Art Nouveau" },
            //    new Categories { Name = "Impressionism" },
            //    new Categories { Name = "Realism" },
            //    new Categories { Name = "Expressionism" },
            //    new Categories { Name = "Photorealism" },
            //    new Categories { Name = "Pop Art" }
            //    );
        }
    }
}
