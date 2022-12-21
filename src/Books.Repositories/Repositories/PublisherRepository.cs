using Books.Core;
using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repositories.Repositories
{
	public class PublisherRepository
	{
		private readonly BooksDbContext _ctx;
		public PublisherRepository(BooksDbContext ctx)
		{
			_ctx = ctx;
		}
		public List<Publisher> GetPublishers()
        {
            return _ctx.Publishers.ToList();
        }

	}
}
