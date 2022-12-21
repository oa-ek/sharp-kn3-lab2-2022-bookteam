using Books.Core;
using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repositories.Repositories
{
    public class AuthorRepository
    {
        private readonly BooksDbContext _ctx;

        public AuthorRepository(BooksDbContext ctx)
        {
            _ctx = ctx;
        }
        public List<Author> GetAllAuthors()
        {
            return _ctx.Authors.ToList();
        }
    }
}
