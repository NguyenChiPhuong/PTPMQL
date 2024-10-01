using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMvc.Models;

namespace WebMvc
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebMvc.Models.Student> Student { get; set; } = default!;

        public DbSet<WebMvc.Models.Person> Person { get; set; } = default!;
    }
}
