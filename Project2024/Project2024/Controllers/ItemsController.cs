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

        [HttpGet("GetCreationDate")]

        public DateTime GetCreationDate(int id)
        {
            if (id>0)
            {
                DateTime dateTime = _itemsService.GetCreationDate(id);
                return dateTime;
            }
            else throw new ArgumentException("Invalid ID format.");

        }

        [HttpGet("GetExpirationDate")]

        public DateTime GetExpirationDate(int id)
        {
            if (id > 0)
            {
                DateTime dateTime = _itemsService.GetExpirationDate(id);
                return dateTime;
            }
            else throw new ArgumentException("Invalid ID format.");

        }
    }
}
