using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Core;
using Books.Core.Entities;

namespace Books.Repositories.Repositories
{
    public class BookRepository
    {
        private readonly BooksDbContext _ctx;
        public BookRepository(BooksDbContext ctx)
        {
            _ctx = ctx;
        }
        public List<Book> GetAllBooks()
        {
            return _ctx.Books.ToList();
        }

        public Book GetBookById(int ID)
        {
            return _ctx.Books.FirstOrDefault(x => x.Id == ID);
        }
    }
}
