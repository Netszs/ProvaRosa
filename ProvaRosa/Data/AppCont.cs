using Microsoft.EntityFrameworkCore;
using ProvaRosa.Models;

namespace ProvaRosa.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
