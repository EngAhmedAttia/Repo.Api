using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repo.Web.Models;
using System.Diagnostics;

namespace Repo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View( _context.Employees.ToList());
        }

       
    }
}