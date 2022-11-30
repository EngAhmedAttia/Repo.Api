using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Repo.Entities.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Repo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly Irepo<Employee> _context;

        public EmployeeController(Irepo<Employee> context)
        {
            _context = context;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.GetAll();
        }

       
    }
}
