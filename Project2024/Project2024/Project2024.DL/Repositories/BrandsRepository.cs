using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.MemoryDb;
using Project2024.Project2024.Models;

namespace Project2024.Project2024.DL.Repositories
{
    public class BrandsRepository : IBrandsRepository
    {
        public List<Brands> GetAll()
        {
            return InMemoryDb.BrandsData;
        }
        public Brands GetById(int Id)
        {
            return InMemoryDb.BrandsData.FirstOrDefault(b => b.Id == Id);
        }
        public void Add (Brands brand)
        {
            InMemoryDb.BrandsData.Add(brand);
        }
        public void Remove (int id)
        {
            var brand= GetById(id);
            InMemoryDb.BrandsData.Remove(brand);
        }
        public DateTime GetFoundationDate(int id)
        {
            return InMemoryDb.BrandsData.FirstOrDefault(x => x.Id == id).FoundationDate;
        }

    }
}
