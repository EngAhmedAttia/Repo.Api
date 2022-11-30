using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Entities.Interface;

namespace Repo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly Irepo<Customer> _context;

        public CustomerController(Irepo<Customer> context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Customer> GetCustomers() 
        {
            return _context.GetAll();
        }
    }
}
