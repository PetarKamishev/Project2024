using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.Models.Requests;
using Project2024.Project2024.Models.Responses;

namespace Project2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        [HttpPost("GetAllItemsByBrandAndDate")]
        public GetAllItemsByBrandResponse?
            GetAllBooksByAuthorAndDate([FromBody] GetAllItemsByBrandRequest request)
        {
            return _storeService.GetGetAllByBrandBeforeDate(request);
        }
    }
}
