using CrudApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
