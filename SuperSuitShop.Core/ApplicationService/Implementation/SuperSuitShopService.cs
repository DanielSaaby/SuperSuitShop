using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Core.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                if (superSuit.Price > 0)
                {
                    return _superSuitShopRepository.CreateSuperSuit(superSuit);
                }
                else
                {
                    throw new InvalidDataException("To create SuperSuit you need a Price");
                }

                
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

        public SuperSuit ReadById(int id)
        {
            return _superSuitShopRepository.ReadById(id);
        }
    }
}
