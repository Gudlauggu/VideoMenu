using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VideoMenuEntity;

namespace VideoMenuDAL.Context
{
    class InMemoryContext : DbContext
    {
        private static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("TheDB").Options;


        public InMemoryContext() : base(options)
        {
            
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
