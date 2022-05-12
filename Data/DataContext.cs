using crudpractisesqlserver.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace crudpractisesqlserver.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Persons> Persons { get; set; }
    }
}
