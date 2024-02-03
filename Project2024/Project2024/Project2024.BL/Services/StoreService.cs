using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.Models.Requests;
using Project2024.Project2024.Models.Responses;

namespace Project2024.Project2024.BL.Services
{
    public class StoreService:IStoreService
    {
        private readonly IItemsService _itemsService;
        private readonly IBrandsService _brandService;

        public StoreService(IBrandsService brandsService, IItemsService itemsService)
        {
            _brandService = brandsService;
            _itemsService = itemsService;
        }

        public GetAllItemsByBrandResponse? GetGetAllByBrandBeforeDate(GetAllItemsByBrandRequest request)
        {
            var response = new GetAllItemsByBrandResponse()
            {
                Brands=_brandService.GetById(request.BrandId),
                Items=_itemsService.GetAllByBrandBeforeDate(request.BrandId, request.DateBefore)
            };
            return response;
        }

        public int CheckItemsCount(int input)
        {
            if (input < 0) return 0;
            var itemsCount = _itemsService.GetAll();
            return itemsCount.Count + input;
        }
    }
}
