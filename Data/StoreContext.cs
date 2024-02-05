using Microsoft.EntityFrameworkCore;
using Re_Store.Entities;

namespace Re_Store.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    
    
    
}