﻿using Microsoft.EntityFrameworkCore;
using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SuperSuitShop.Infrastructure.Data.Repositories
{
    public class SuperSuitShopRepository : ISuperSuitShopRepository
    {
        readonly SuperSuitShopContext _ctx;

        public SuperSuitShopRepository(SuperSuitShopContext ctx)
        {
            _ctx = ctx;
        }

        public SuperSuit CreateSuperSuit(SuperSuit superSuit)
        {
            _ctx.Attach(superSuit).State = EntityState.Added;
            _ctx.SaveChanges();
            return superSuit;
        }

        public SuperSuit DeleteSuperSuit(int id)
        {
            throw new System.NotImplementedException();
        }

        public SuperSuit NewSuperSuit(string name, string type, double price, string description)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SuperSuit> ReadAll(Filter filter)
        {
            if (filter.CurrentPage != 0 && filter.ItemsPrPage != 0)
            {
                return _ctx.superSuits
                .Skip((filter.CurrentPage - 1) * filter.ItemsPrPage)
                .Take(filter.ItemsPrPage);

                
            }

            return _ctx.superSuits;
        }

        public SuperSuit UpdateSuperSuit(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
