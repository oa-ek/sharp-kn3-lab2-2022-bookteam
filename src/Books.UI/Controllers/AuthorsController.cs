using Books.Core;
using Books.Core.Entities;
using Books.Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        // GET: ActorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author)
        {
            dbContext.Authors.Add(author);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = dbContext.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }

        // POST: ActorController/Edit/5
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            Author edited = dbContext.Authors.FirstOrDefault(x => x.Id == author.Id);
            edited.Name = author.Name;

            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: ActorController/Delete/5
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Authors.Find(id));
        }

        // POST: ActorController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Authors.Remove(dbContext.Authors.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
