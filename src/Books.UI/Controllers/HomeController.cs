using Books.Core;
using Books.Repositories;
using Books.Repositories.Repositories;
using Books.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Books.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly BooksDbContext dbContext;
        public HomeController(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}