using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PjAguinaldoMulonde.Models;

namespace PjAguinaldoMulonde.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

      public  DbSet<Psico> psicos { get; set; }
    }
}
