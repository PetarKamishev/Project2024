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
                Brand=" "
            },
              new Items()
            {
                Id = 2,
                Name = "Water",
                Price = 5,
                Quantity = 10,
                Description ="Water",
                Brand="Devin"
            },
                new Items()
            {
                Id = 3,
                Name = "Apples",
                Price = 4,
                Quantity = 30,
                Description ="Fruits",
                Brand=" "
            }
        };
    }
}
