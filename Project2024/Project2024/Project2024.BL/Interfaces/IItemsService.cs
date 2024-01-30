using Project2024.Project2024.Models;

namespace Project2024.Project2024.BL.Interfaces
{
    public interface IItemsService
    {
        List<Items> GetAll();
        Items GetById(int id);
        void Add(Items items);
        void Remove(int id);

        DateTime GetCreationDate(int id);

        DateTime GetExpirationDate(int id);
    }
}
