using Microsoft.AspNetCore.Mvc;
using Books.Core;
//using MoviesUI.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MoviesUI.Controllers
{
    public class BookmarkController : Controller
    {
        private readonly BooksDbContext dbContext;
        public BookmarkController(BooksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var currentUser = dbContext.Users.Include(x => x.Books).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (currentUser != null)
            {
                return View(currentUser.Books?.ToList());
            }
            return View();
        }
        public ActionResult Remove(int id)
        {
            var currentUser = dbContext.Users.Include(x => x.Books).FirstOrDefault(x => x.UserName == User.Identity.Name);
            currentUser?.Books?.Remove(currentUser.Books.FirstOrDefault(x => x.Id == id));
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
