using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PracticeProblem_2.Models;

namespace PracticeProblem_2.Data
{
    public class OdersDbContext : DbContext
    {
        public OdersDbContext (DbContextOptions<OdersDbContext> options)
            : base(options)
        {
        }

        public DbSet<PracticeProblem_2.Models.Orders> Orders { get; set; } = default!;
    }
}
