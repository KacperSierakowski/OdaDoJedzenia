namespace Nauka3.Migrations
{
    using Nauka3.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nauka3.Models.OdaDoJedzeniaDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Nauka3.Models.OdaDoJedzeniaDb";
        }

        protected override void Seed(Nauka3.Models.OdaDoJedzeniaDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Models.Restaurant { Name = "Warzywniak", City = "Wroc³aw", Country = "Polska" },
                new Models.Restaurant { Name = "Piec na Szewskiej", City = "Wroc³aw", Country = "Polska" },
                new Models.Restaurant { Name = "KALAPIZZA", City = "Wroc³aw", Country = "Polska" },
                new Models.Restaurant {
                    Name = "Mango Mama",
                    City = "Wroc³aw",
                    Country = "Polska",
                    Reviews = 
                        new List<RestaurantReview>{
                        new RestaurantReview{Rating=7,RestaurantID=2,Body="Wszystko spoko,ale zielone curry by³o zbyt wodniste",ReviewerName="Kacper"}
                    }
                });



        }
    }
}
