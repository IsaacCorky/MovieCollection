using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCollection.Models
{
    public interface IMovieRepository
    {
        IQueryable<NewMovie> NewMovie { get; }

    }
}