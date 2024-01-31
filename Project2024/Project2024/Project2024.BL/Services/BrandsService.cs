using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.DL.Interfaces;
using Project2024.Project2024.DL.MemoryDb;
using Project2024.Project2024.Models;

namespace Project2024.Project2024.BL.Services
{
    public class BrandsService: IBrandsService
    {
        private readonly IBrandsRepository _brandsRepository;
        public BrandsService(IBrandsRepository brandsRepository )
        {
            _brandsRepository = brandsRepository;
        }
        public List<Brands> GetAll()
        {
            return _brandsRepository.GetAll();
        }
        public void Add(Brands brand)
        {
            _brandsRepository.Add(brand);
        }
        public void Remove(int id)
        {
            _brandsRepository.Remove(id);
        }
        public DateTime GetFoundationDate(int id)
        {
            return _brandsRepository.GetFoundationDate(id);
        }
        public Brands GetById(int id)
        {
            return _brandsRepository.GetById(id);
        }
    }
}
