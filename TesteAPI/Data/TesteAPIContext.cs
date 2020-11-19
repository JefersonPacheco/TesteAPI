	using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteAPI.Models
{
    public class TesteAPIContext : DbContext
    {
        public TesteAPIContext (DbContextOptions<TesteAPIContext> options)
            : base(options)
        {
        }

        public DbSet<TesteAPI.Models.Empresa> Empresa { get; set; }
    }
}
