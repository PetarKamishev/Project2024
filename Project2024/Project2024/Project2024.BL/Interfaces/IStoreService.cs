using Project2024.Project2024.Models.Requests;
using Project2024.Project2024.Models.Responses;

namespace Project2024.Project2024.BL.Interfaces
{
    public interface IStoreService
    {
        GetAllItemsByBrandResponse GetGetAllByBrandBeforeDate(GetAllItemsByBrandRequest request);
        public int CheckItemsCount(int input);
    }
}
