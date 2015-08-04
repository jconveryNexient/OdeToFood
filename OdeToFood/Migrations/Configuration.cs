using System.Collections.Generic;
using System.Security;
using OdeToFood.Models;

namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDb";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            //  This method will be called after migrating to the latest version.
            context.Restaurants.AddOrUpdate(r=>r.Name,
                new Restaurant {Name="Sabatinos", City="Baltimore", Country="USA"},
                new Restaurant {Name = "Great Lake", City = "Chicago", Country = "USA"},
                new Restaurant()
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country="Sweden",
                    Reviews =
                        new List<RestaurantReview>
                        {
                            new RestaurantReview {Rating = 9, Body = "Great Food!" }
                        }    
                });
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
        }
    }
}
