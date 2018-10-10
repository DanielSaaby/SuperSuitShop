using SuperSuitShop.Core.Entities;
using System.Collections.Generic;

namespace SuperSuitShop.Core.ApplicationService
{
    public interface ISuperSuitShopService
    {
        SuperSuit NewSuperSuit(string name, string type, double price, string description);

        SuperSuit CreateSuperSuit(SuperSuit superSuit);

        List<SuperSuit> ReadAll();

        SuperSuit UpdateSuperSuit(SuperSuit superSuit);

        SuperSuit DeleteSuperSuit(int id);

        List<SuperSuit> GetFilteredSuits(Filter filter);

        SuperSuit ReadById(int id);
    }
}
