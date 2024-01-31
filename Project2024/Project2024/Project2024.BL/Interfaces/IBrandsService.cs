using Project2024.Project2024.Models;

namespace Project2024.Project2024.BL.Interfaces
{
    public interface IBrandsService
    {
     
            List<Brands> GetAll();
            Brands GetById(int id);
            void Add(Brands brand);
            void Remove(int id);

            DateTime GetFoundationDate(int id);

    }
}
