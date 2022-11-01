using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rosca_Antonia_Lab2.Models;

namespace Rosca_Antonia_Lab2.Data
{
    public class Rosca_Antonia_Lab2Context : DbContext
    {
        public Rosca_Antonia_Lab2Context (DbContextOptions<Rosca_Antonia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Rosca_Antonia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Rosca_Antonia_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
