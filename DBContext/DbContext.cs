using Microsoft.EntityFrameworkCore;
using SeniorWebAPIProjectV3.Models;

namespace SeniorWebAPIProjectV3.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Swap> Swaps { get; set; }
        public DbSet<User> Users { get; set; }
    }
}