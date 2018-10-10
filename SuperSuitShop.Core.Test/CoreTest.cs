using Moq;
using SuperSuitShop.Core.ApplicationService;
using SuperSuitShop.Core.ApplicationService.Implementation;
using SuperSuitShop.Core.DomainService;
using SuperSuitShop.Core.Entities;
using System;
using System.IO;
using Xunit;

namespace SuperSuitShop.Core.Test
{
    public class CoreTest
    {
        

        [Fact]
        public void CreateSuperSuitPriceMissingThrowsException()
        {
            var superSuitRepo = new Mock<ISuperSuitShopRepository>();
            superSuitRepo.Setup(x => x.ReadById(It.IsAny<int>()))
                .Returns(new SuperSuit() { Id = 1 });
           
            ISuperSuitShopService service = new SuperSuitShopService(superSuitRepo.Object);
            var superSuit = new SuperSuit()
            {
                
                Price = double.MinValue
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateSuperSuit(superSuit));
            Assert.Equal("To create SuperSuit you need a Price", ex.Message);
        }
    }
}
