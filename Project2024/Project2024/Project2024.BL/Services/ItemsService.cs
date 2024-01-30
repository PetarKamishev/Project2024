using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.MemoryDb;
using Project2024.Project2024.Models;

namespace Project2024.Project2024.BL.Services
{
    public class ItemsService : IItemsService
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsService(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public List<Items> GetAll()
        {
            return _itemsRepository.GetAll();
        }
        public Items GetById(int id)
        {
            if (id <= 0) return new Items();

            return _itemsRepository.GetById(id);
        }

        public void Add(Items item)
        {
            _itemsRepository.Add(item);
        }
        public void Remove (int id)
        {
            _itemsRepository.Remove(id);
        }

        public DateTime GetCreationDate(int id)
        {
            return InMemoryDb.ItemsData.FirstOrDefault(x => x.Id == id).CreationDate;
        }

        public DateTime GetExpirationDate(int id)
        {
            return InMemoryDb.ItemsData.FirstOrDefault(x => x.Id == id).ExpirationDate;
        }
    }
}
