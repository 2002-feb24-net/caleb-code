using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProjectStarter.Models;

namespace MvcProjectStarter.Data
{
    public class MvcProjectStarterContext : DbContext
    {
        public MvcProjectStarterContext (DbContextOptions<MvcProjectStarterContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProjectStarter.Models.Song> Song { get; set; }
    }
}
