using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UdemyTeste.Models;

namespace UdemyTeste.Data
{
    public class UdemyTesteContext : DbContext
    {
        public UdemyTesteContext (DbContextOptions<UdemyTesteContext> options)
            : base(options)
        {
        }

        public DbSet<UdemyTeste.Models.Department> Department { get; set; } = default!;
    }
}
