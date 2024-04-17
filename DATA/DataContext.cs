using CP2_CSHARP.Models;
using Microsoft.EntityFrameworkCore;

namespace CP2_CSHARP.DATA
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        { 
        }

        public DbSet<User> MVC_USUARIO { get; set; }

    }
}
