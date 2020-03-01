using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FatihTuna.Models;

namespace FatihTuna.Models
{
    public class FatihTunaContext : DbContext
    {
        public FatihTunaContext (DbContextOptions<FatihTunaContext> options)
            : base(options)
        {
        }

        public DbSet<FatihTuna.Models.Post> Post { get; set; }

        public DbSet<FatihTuna.Models.Comment> Comment { get; set; }
    }
}
