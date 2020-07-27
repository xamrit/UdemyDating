using Microsoft.EntityFrameworkCore;
using UdemyDating.API.Models;

namespace UdemyDating.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Value> Values { get; set; }
    }
}
