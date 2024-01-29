using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.Models;

namespace Project2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;

        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }
        [HttpGet("GetAll")]
        public List<Items> GetAll() {
            return _itemsService.GetAll();
        }

        [HttpGet("GetById")]

        public Items GetById(int id)
        {
            return _itemsService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add(Items item)
        {
            _itemsService.Add(item);
        }

        [HttpDelete("Delete")]
        public void Delete(int id) 
        {
            _itemsService.Remove(id);
        }
    }
}
