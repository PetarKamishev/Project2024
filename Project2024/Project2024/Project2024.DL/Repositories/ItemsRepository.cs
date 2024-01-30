using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.MemoryDb;
using Project2024.Project2024.Models;
using System;

namespace Project2024.Project2024.DL.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        public List<Items> GetAll()
        {
            return InMemoryDb.ItemsData;
        }
        public void Add (Items item)
        {
            InMemoryDb.ItemsData.Add(item);
        }
        public Items GetById (int id)
        {
            return InMemoryDb.ItemsData.FirstOrDefault(x => x.Id == id);
        }
        public void Remove (int id)
        {
            var item = GetById(id);
            InMemoryDb.ItemsData.Remove(item);
        }

        public DateTime GetCreationDate(int id)
        {
            return InMemoryDb.ItemsData.FirstOrDefault(x=>x.Id == id).CreationDate;
        }

        public DateTime GetExpirationDate(int id)
        {
            return InMemoryDb.ItemsData.FirstOrDefault(x => x.Id == id).ExpirationDate;
        }
    }
}
