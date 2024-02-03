using Moq;
using Project2024.Project2024.BL.Services;
using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.Repositories;
using Project2024.Project2024.Models;
using Project2024.Project2024.Models.Requests;

namespace Project2024.Tests
{
    public class UnitTest1
    {
        public static List<Items> ItemsData = new List<Items>()
        {
            new Items()
            {
                Id = 1,
                Name = "Bread",
                Price = 1.60M,
                Quantity = 10,
                Description ="Food",
                Brand="Pirina",
                BrandId=1,
                CreationDate = DateTime.Now,
                ExpirationDate = new DateTime(2024,02,11)
            },
              new Items()
            {
                Id = 2,
                Name = "Water",
                Price = 5,
                Quantity = 10,
                Description ="Water",
                Brand="Devin",
                BrandId=2,
                CreationDate= DateTime.Now,
                ExpirationDate= new DateTime(2024,05,20)
              },
                new Items()
            {
                Id = 3,
                Name = "Apples",
                Price = 4,
                Quantity = 30,
                Description ="Fruits",
                Brand="ApplesCompany",
                BrandId=3,
                CreationDate = DateTime.Now,
                ExpirationDate= new DateTime(2024,02,11)
            }
        };

        public static List<Brands> BrandsData = new List<Brands>()
        {
            new Brands()
            {
                Id= 1,
                Name="Pirina",
                FoundationDate=new DateTime(2000, 05, 01)
            },
            new Brands()
            {
                Id=2,
                Name="Devin",
                FoundationDate=new DateTime(1992, 01, 01)
            },
            new Brands()
            {
                Id=3,
                Name="ApplesCompany",
                FoundationDate=new DateTime(1985, 03, 14)
            }
        };
        [Fact]
        public void CheckItemsCount_OK()
        {
            //setup

            var input = 10;
            var expectedCount = 13;

            var mockedItemsRepository = new Mock<IItemsRepository>();

            mockedItemsRepository.Setup(x => x.GetAll()).Returns(ItemsData);

            //inject

            var itemsService = new ItemsService(mockedItemsRepository.Object);
            var brandsService = new BrandsService(new BrandsRepository());
            var service = new StoreService(brandsService, itemsService);

            //act

            var result = service.CheckItemsCount(input);
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void CheckItemsCount_NegativeInput()
        {
            //setup

            var input = -10;
            var expectedCount = 0;

            var mockedItemsRepository = new Mock<IItemsRepository>();

            mockedItemsRepository.Setup(x => x.GetAll()).Returns(ItemsData);

            //inject

            var itemsService = new ItemsService(mockedItemsRepository.Object);
            var brandsService = new BrandsService(new BrandsRepository());
            var service = new StoreService(brandsService, itemsService);

            //act

            var result = service.CheckItemsCount(input);

            //assert

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetGetAllByBrandBeforeDate_OK()
        {
            //setup
            var request = new GetAllItemsByBrandRequest
            {
                BrandId = 1,
                DateBefore = new DateTime(2024, 08, 01)
            };
            var expectedCount = 1;

            var mockedItemsRepository = new Mock<IItemsRepository>();
            var mockedBrandsRepository = new Mock<IBrandsRepository>();

            mockedItemsRepository.Setup(x => x.GetAllByBrand(request.BrandId))
                .Returns(ItemsData.Where(b => b.BrandId == request.BrandId).ToList());

            mockedBrandsRepository.Setup(x => x.GetById(request.BrandId)).Returns(BrandsData!.FirstOrDefault(a => a.Id == request.BrandId)!);

            //inject

            var itemsService = new ItemsService(mockedItemsRepository.Object);
            var brandsService = new BrandsService(mockedBrandsRepository.Object);
            var service = new StoreService(brandsService, itemsService);

            //act

            var result = service.GetGetAllByBrandBeforeDate(request);

            //Assert

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result!.Items.Count);
            Assert.Equal(request.BrandId, result.Brands.Id);
        }
    }
}