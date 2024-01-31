using Project2024.Project2024.Models;

namespace Project2024.Project2024.DL.MemoryDb
{
    public static class InMemoryDb
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
    }
}
