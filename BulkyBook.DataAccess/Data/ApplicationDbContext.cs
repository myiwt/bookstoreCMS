using Microsoft.EntityFrameworkCore;
using BulkyBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BulkyBookWeb.DataAccess;

public class ApplicationDbContext: IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<CoverType> CoverTypes { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Company> Companies { get; set; }
}
