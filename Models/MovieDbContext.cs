﻿using System;
using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<NewMovie> NewMovie { get; set; }
    }
}