using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class movies : DbContext
    {
        public movies (DbContextOptions<movies> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.movie> movie { get; set; } = default!;
    }
