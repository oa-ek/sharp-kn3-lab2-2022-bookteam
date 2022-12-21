using Books.Core;
using Books.Repositories.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

		// GET: PublishersController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: PublishersController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: PublishersController/Create
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

		// GET: PublishersController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: PublishersController/Edit/5
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

		// GET: PublishersController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: PublishersController/Delete/5
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
