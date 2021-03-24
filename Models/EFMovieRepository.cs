using System;
using System.Linq;

namespace MovieCollection.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private MovieDbContext _context;

        public EFMovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public IQueryable<NewMovie> NewMovie => _context.NewMovie;

    }
}