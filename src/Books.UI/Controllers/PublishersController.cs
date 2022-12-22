using Books.Core;
using Books.Core.Entities;
using Books.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Books.UI.Controllers
{
	public class PublishersController : Controller
	{
        private readonly PublisherRepository _publisherRepository;
        private readonly BooksDbContext dbContext;
        public PublishersController(BooksDbContext dbContext)
        {
            _publisherRepository = new PublisherRepository(dbContext);
            this.dbContext = dbContext;
        }
        // GET: ActorController
        public ActionResult Index()
        {            
            var publishers = _publisherRepository.GetPublishers();
            return View(publishers);
        }
        public ActionResult FilteredList(int id)
        {
            var query = from x in dbContext.Books
                        where x.Publishers.Id == id
                        select x;
            return View(query.ToList());
        }

		// GET: PublishersController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: PublishersController/Create
		[HttpPost]
		public ActionResult Create(Publisher publisher)
		{
            dbContext.Publishers.Add(publisher);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
		}

		// GET: PublishersController/Edit/5
		public ActionResult Edit(int id)
		{
            Publisher publisher = dbContext.Publishers.FirstOrDefault(x => x.Id == id);
            if (publisher == null) return NotFound();
            return View(publisher);
		}

		// POST: PublishersController/Edit/5
		[HttpPost]
		public ActionResult Edit(Publisher publisher)
		{
            Publisher edited = dbContext.Publishers.FirstOrDefault(x => x.Id == publisher.Id);
            edited.Name = publisher.Name;

            dbContext.Entry(edited).State = EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
		}

		// GET: PublishersController/Delete/5
		public ActionResult Delete(int? id)
		{
            return View(dbContext.Publishers.Find(id));
		}

		// POST: PublishersController/Delete/5
		[HttpPost]
		public ActionResult Delete(int id)
		{
            try
            {
                dbContext.Publishers.Remove(dbContext.Publishers.Find(id));
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["AlertMessage"] = "Failed to remove the publisher";
                return View();
            }
		}
	}
}
