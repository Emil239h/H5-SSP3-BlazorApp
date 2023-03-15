using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace H5_SSP3_BlazorApp.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) {}

        public DbSet<Todo> Todos => Set<Todo>();

    }

}