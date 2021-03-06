﻿using System;
using Microsoft.EntityFrameworkCore;
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
            var superSuitRemoved = _ctx.Remove(new SuperSuit {Id = id}).Entity;
            _ctx.SaveChanges();
            return superSuitRemoved;
        }

        public SuperSuit NewSuperSuit(string name, string type, double price, string description)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SuperSuit> ReadAll(Filter filter)
        {
            if (filter.CurrentPage != 0 && filter.ItemsPrPage != 0)
            {
                return _ctx.SuperSuits
                .Skip((filter.CurrentPage - 1) * filter.ItemsPrPage)
                .Take(filter.ItemsPrPage);

                
            }

            return _ctx.SuperSuits;
        }

        public SuperSuit ReadById(int id)
        {
            return _ctx.SuperSuits.FirstOrDefault(ss => ss.Id == id);
        }

        public SuperSuit UpdateSuperSuit(SuperSuit superSuit)
        {
            SuperSuit ss = null;
            try
            {
                ss = _ctx.Update(superSuit).Entity;
                _ctx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return ss;
        }
    }
}
