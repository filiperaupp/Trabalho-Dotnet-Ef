using Microsoft.EntityFrameworkCore;

namespace my_crud.Models
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Dog> Dogs { get; set; } 
    }
}