namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.MovieDBContext context)
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

            context.Movies.AddOrUpdate(i => i.Name,
                                        new movieModel
                                        {
                                            Name = "When Harry Met Sally",
                                            reciverDate = DateTime.Parse("1989-1-11"),
                                            Genre = "Romantic Comedy",
                                            price = 7.99M
                                        },

                                         new movieModel
                                         {
                                             Name = "Ghostbusters ",
                                             reciverDate = DateTime.Parse("1984-3-13"),
                                             Genre = "Comedy",
                                             price = 8.99M
                                         },

                                         new movieModel
                                         {
                                             Name = "Ghostbusters 2",
                                             reciverDate = DateTime.Parse("1986-2-23"),
                                             Genre = "Comedy",
                                             price = 9.99M
                                         },

                                       new movieModel
                                       {
                                           Name = "Rio Bravo",
                                           reciverDate = DateTime.Parse("1959-4-15"),
                                           Genre = "Western",
                                           price = 3.99M
                                       }
                                   );
        }
    }
}
