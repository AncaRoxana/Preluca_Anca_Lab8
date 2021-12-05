using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Preluca_Anca_Lab8.Models;

namespace Preluca_Anca_Lab8.Data
{
    public class Preluca_Anca_Lab8Context : DbContext
    {
        public Preluca_Anca_Lab8Context (DbContextOptions<Preluca_Anca_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Preluca_Anca_Lab8.Models.Book> Book { get; set; }

        public DbSet<Preluca_Anca_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Preluca_Anca_Lab8.Models.Category> Category { get; set; }
    }
}
