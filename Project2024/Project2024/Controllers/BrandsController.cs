using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project2024.Project2024.BL.Interfaces;
using Project2024.Project2024.BL.Services;
using Project2024.Project2024.Models;

namespace Project2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandsService _brandsService;

        public BrandsController(IBrandsService brandsService)
        {
            _brandsService = brandsService;
        }
        [HttpGet("GetAll")]
        public List<Brands> GetAll()
        {
            return _brandsService.GetAll();
        }

        [HttpGet("GetById")]

        public Brands GetById(int id)
        {
            return _brandsService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add(Brands brand)
        {
            _brandsService.Add(brand);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _brandsService.Remove(id);
        }

        [HttpGet("GetCreationDate")]

        public DateTime GetCreationDate(int id)
        {
            if (id > 0)
            {
                DateTime dateTime = _brandsService.GetFoundationDate(id);
                return dateTime;
            }
            else throw new ArgumentException("Invalid ID format.");

        }
    }
}
