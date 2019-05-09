using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesCore30.Models
{
    public class RazorPagesCore30Context : DbContext
    {
        public RazorPagesCore30Context (DbContextOptions<RazorPagesCore30Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesCore30.Models.Movie> Movie { get; set; }
    }
}
