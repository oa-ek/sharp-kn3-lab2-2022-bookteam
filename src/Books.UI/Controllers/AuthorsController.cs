using Books.Core;
using Books.Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Books.UI.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AuthorRepository _authorRepository;
        private readonly BooksDbContext dbContext;
        public AuthorsController(BooksDbContext dbContext)
        {
            _authorRepository = new AuthorRepository(dbContext);
            this.dbContext = dbContext;
        }

        // GET: ActorController
        public ActionResult Index()
        {            
            var authors = _authorRepository.GetAllAuthors();
            //ViewData["Genres"] = allgenres;
            return View(authors);

            return View();
        }
        public ActionResult FilteredList(int id)
        {
            var query = from x in dbContext.Books
                        where x.Authors.Any(x => x.Id == id)
                        select x;
            return View(query.ToList());
        }

        // GET: ActorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ActorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ActorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ActorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ActorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ActorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
