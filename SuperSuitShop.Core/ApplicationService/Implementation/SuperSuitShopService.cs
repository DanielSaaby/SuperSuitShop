using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSuitShop.Core.ApplicationService.Implementation
{
    public class SuperSuitShopService : ISuperSuitShopService
    {
        
            readonly ISuperSuitShopRepository _superSuitShopRepository;

            public SuperSuitShopService(ISuperSuitShopRepository superSuitRepository)
            {
                _superSuitShopRepository = superSuitRepository;
            }

            public SuperSuit NewSuperSuit(string name, string type, double price, string description)
            {
                var superSuit = new SuperSuit()
                {
                    Name = name,
                    Type = type,
                    Price = price,
                    Description = description
                };
                return superSuit;
            }

            public SuperSuit CreateSuperSuit(SuperSuit superSuit)
            {
                return _superSuitShopRepository.CreateSuperSuit(superSuit);
            }

            public List<SuperSuit> ReadAll()
            {
                return _superSuitShopRepository.ReadAll().ToList();
            }

            public SuperSuit UpdateSuperSuit(SuperSuit superSuit)
            {
                return _superSuitShopRepository.UpdateSuperSuit(superSuit);
            }

            public SuperSuit DeleteSuperSuit(int id)
            {
                return _superSuitShopRepository.DeleteSuperSuit(id);
            }


        public List<SuperSuit> GetFilteredSuits(Filter filter)
        {
            return _superSuitShopRepository.ReadAll(filter).ToList();
        }

    }
}
