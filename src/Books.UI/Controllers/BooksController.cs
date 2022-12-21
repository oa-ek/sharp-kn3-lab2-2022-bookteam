using Books.Core;
using Books.Core.Entities;
using Books.Repositories.Repositories;
using Books.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace Books.UI.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksDbContext dbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BooksController(BooksDbContext dbContext, IWebHostEnvironment webHostEnvironment)
		{
			this.dbContext = dbContext;
			_webHostEnvironment = webHostEnvironment;
		}
		// GET: MovieController
		public ActionResult Index()
        {
            var BooksWithEv = dbContext.Books
                .Include(x => x.Genres)
                .Include(x => x.Authors)
                .Include(x => x.Publishers)
                .ToList();

            return View(BooksWithEv);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string bookSearch)
        {
            ViewData["GetBooksDetails"] = bookSearch;

            var bquery = from x in dbContext.Books select x;
            if(!String.IsNullOrEmpty(bookSearch))
            {
                bquery = bquery.Where(x => x.Title.Contains(bookSearch)
                || x.Authors.Any(x => x.Name.Contains(bookSearch))
                || x.Publishers.Name.Contains(bookSearch)
                || x.Description.Contains(bookSearch)
                || x.Genres.Any(x => x.GenreName.Contains(bookSearch))
                || x.PublishDate.ToString().Contains(bookSearch));
            }
            return View(await bquery.Include(x => x.Authors).ToListAsync());
        }
        // GET: MovieController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var book = dbContext.Books
                .Include(x => x.Authors)
                .Include(x => x.Genres)
                .Include(x => x.Publishers)
                .FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        // GET: MovieController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Genres = dbContext.Genres.ToList();
            ViewBag.Authors = dbContext.Authors.ToList();
            ViewBag.Publishers = dbContext.Publishers.ToList();
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        public ActionResult Create(Book book, string publisher, string[] authors, string[] genres, IFormFile Image)
        {
            if (publisher != null)
            {
                book.Publishers = dbContext.Publishers.FirstOrDefault(x => x.Name == publisher);
            }
            if (genres != null)
            {
                book.Genres = new List<Genre>();
                foreach (var g in dbContext.Genres.Where(ge => genres.Contains(ge.GenreName)))
                {
                    book.Genres.Add(g);
                }
            }
            if (authors != null)
            {
                book.Authors = new List<Author>();
                foreach (var a in dbContext.Authors.Where(au => authors.Contains(au.Name)))
                {
                    book.Authors.Add(a);
                }
            }
            string PicturePath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", Image.FileName);
                using(FileStream stream = new FileStream(PicturePath, FileMode.Create))
                Image.CopyTo(stream);

            book.IconPath = Path.Combine("Images", Image.FileName);
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Book book = dbContext.Books
                .Include(x => x.Publishers)
                .Include(x => x.Genres)
                .Include(x => x.Authors)
                .FirstOrDefault(x => x.Id == id);
            if (book == null) return NotFound();
            ViewBag.Publishers = dbContext.Publishers.ToList();
            ViewBag.Genres = dbContext.Genres.ToList();
            ViewBag.Authors = dbContext.Authors.ToList();
            return View(book);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        public ActionResult Edit(Book book, string publisher, string[] authors, string[] genres)
        {
            
            Book edited = dbContext.Books.Include(x => x.Genres).Include(x => x.Authors).FirstOrDefault(x => x.Id == book.Id);
            edited.Title = book.Title;
            edited.Description = book.Description;
            edited.PageCount = book.PageCount;
            edited.Rating = book.Rating;
            edited.IconPath = book.IconPath;
            edited.PublishDate = book.PublishDate;

            if (publisher != null)
            {
                edited.Publishers = dbContext.Publishers.FirstOrDefault(x => x.Name == publisher);
            }

            edited.Authors.Clear();
            if(authors != null)
            {
                foreach (var a in dbContext.Authors.Where(au => authors.Contains(au.Name)))
                {
                    edited.Authors.Add(a);
                }
            }

            edited.Genres.Clear();
            if (genres != null)
            {
                foreach (var g in dbContext.Genres.Where(ge => genres.Contains(ge.GenreName)))
                {
                    edited.Genres.Add(g);
                }
            }
            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
		[HttpGet]
        public FileContentResult GetImage(int id)
		{
            var item = dbContext.Books.Find(id);
            var path = Path.Combine(_webHostEnvironment.WebRootPath, item.IconPath);
            var byteArray = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(byteArray, "image/jpeg");
		}

        // GET: MovieController/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            return View(dbContext.Books.Find(id));
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            dbContext.Books.Remove(dbContext.Books.Find(id));
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
