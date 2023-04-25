using DotNet.ReStore.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet.ReStore.API.Data;



public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
