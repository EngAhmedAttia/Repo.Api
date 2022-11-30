using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Entities.Interface;

namespace Repo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Irepo<Product> _context;

        public ProductController(Irepo<Product> context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts() 
        {
            return _context.GetAll();
        }
    }
}
