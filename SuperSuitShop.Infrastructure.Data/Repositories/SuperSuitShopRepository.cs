using System;
using Microsoft.EntityFrameworkCore;
using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Core.Entities;
using System.Collections.Generic;

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

        public IEnumerable<SuperSuit> ReadAll()
        {
            return _ctx.superSuits;
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
