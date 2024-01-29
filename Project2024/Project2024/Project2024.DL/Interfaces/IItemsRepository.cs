using Project2024.Project2024.Models;

namespace Project2024.Project2024.DL.Interfaces
{
    public interface IItemsRepository
    {
        List<Items> GetAll();
        Items GetById (int id);
        void Add(Items items);
        void Remove(int id);

    }
}
