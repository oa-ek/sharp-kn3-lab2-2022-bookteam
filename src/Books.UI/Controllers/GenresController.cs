using Books.Core;
using Books.Core.Entities;
using Books.Repositories.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books.UI.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreRepository _genreRepository;
        private readonly BooksDbContext dbContext;
        public GenresController(BooksDbContext dbContext)
        {
            _genreRepository = new GenreRepository(dbContext);
            this.dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var allgenres = _genreRepository.GetGenres();
            //ViewData["Genres"] = allgenres;
            return View(allgenres);
        }
        public ActionResult FilteredList(int id)
        {
            var query = from x in dbContext.Books
                        where x.Genres.Any(x => x.Id == id)
                        select x;
            return View(query.ToList());
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            dbContext.Genres.Add(genre);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            Genre genre = dbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (genre == null) return NotFound();
            return View(genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            Genre edited = dbContext.Genres.FirstOrDefault(x => x.Id == genre.Id);
            edited.GenreName = genre.GenreName;

            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: GenreController/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Genres.Find(id));
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Genres.Remove(dbContext.Genres.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
