﻿using SuperSuitShop.Core.Entities;
using System.Collections.Generic;

namespace SuperSuitShop.Core.DomainService
{
    public interface ISuperSuitShopRepository
    {
        SuperSuit NewSuperSuit(string name, string type, double price, string description);

        SuperSuit CreateSuperSuit(SuperSuit superSuit);

        IEnumerable<SuperSuit> ReadAll(Filter filter = null);

        SuperSuit UpdateSuperSuit(SuperSuit superSuit);

        SuperSuit DeleteSuperSuit(int id);

        SuperSuit ReadById(int id);
    }
}
