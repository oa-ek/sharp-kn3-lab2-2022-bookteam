using Books.Core;
using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repositories.Repositories
{
    public class GenreRepository
    {
        private readonly BooksDbContext _ctx;
        public GenreRepository(BooksDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Genre> GetGenres()
        {
            return _ctx.Genres.ToList();
        }

    }
}
