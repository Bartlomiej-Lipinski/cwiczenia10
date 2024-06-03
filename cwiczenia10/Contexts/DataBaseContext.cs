using cwiczenia10.Models;
using Microsoft.EntityFrameworkCore;
namespace cwiczenia10.Contexts;

public class DataBaseContext : DbContext
{
    public DbSet<Accounts> Accounts { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<ShopingCarts> ShopingCarts { get; set; }
    public DbSet<ProductCategories> ProductCategories { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Categories> Categories { get; set; }
    
    public DataBaseContext()
    {
    }
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

}