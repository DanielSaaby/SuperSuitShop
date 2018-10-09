using SuperSuitShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperSuitShop.Infrastructure.Data
{
    public class DBInitializer
    {
        public static void SeedDB(SuperSuitShopContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            var superSuit1 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Captain America Suit",
                Type = "Captain America",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit2 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Spiderman Suit",
                Type = "Spiderman",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit3 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Ironman Suit",
                Type = "Ironman",
                Price = 99999.99,
                Description = "Blue, White, Red"
            });

            var superSuit4 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Hulk Skin",
                Type = "Hulk",
                Price = 9999.99,
                Description = "Blue, White, Red"
            });

            var superSuit5 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Thor Suit",
                Type = "Thor",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit6 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Loke Suit",
                Type = "Thor",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit7 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Thanos Suit",
                Type = "Avengers",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit8 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Wonder Woman Suit",
                Type = "Wonder woman",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit9 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Black Widow Suit",
                Type = "Captain America",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit10 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Batman Suit",
                Type = "Batman",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit11 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Catwoman Suit",
                Type = "Batman",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit12 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Black Panther Suit",
                Type = "´Black Panther",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit13 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Doctor Strange Suit",
                Type = "Doctor Strange",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit14 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Star Lord Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit15 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Groot Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit16 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Rocket Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit17 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Gamora Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit18 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Drax Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit19 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Clint Barton Suit",
                Type = "Avengers",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            var superSuit20 = ctx.superSuits.Add(new SuperSuit()
            {

                Name = "Nick Fury Suit",
                Type = "Guardians of the Galaxy",
                Price = 999.99,
                Description = "Blue, White, Red"
            });

            ctx.SaveChanges();

        }

    }
}

